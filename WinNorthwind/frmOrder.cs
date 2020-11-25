using NorthwindVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinNorthwind.Services;

namespace WinNorthwind
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            //코드 데이터들을 조회해서 콤보박스 바인딩
            string[] gubun = { "Customer", "Employee", "Category" };

            CommonService service = new CommonService();
            List<ComboItemVO> allList = service.GetCodeInfoByCodeTypes(gubun);

            CommonUtil.ComboBinding(cboCustomer, allList, "Customer", true, "선택");
            CommonUtil.ComboBinding(cboEmployee, allList, "Employee");
            CommonUtil.ComboBinding(cboCategory, allList, "Category");

            //배송희망일(납기희망일) 7일 후로 셋팅
            dtpRequiredDate.Value = DateTime.Now.AddDays(7);

            //장바구니 데이터그리드뷰의 항목을 셋팅

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //카테고리를 실제적으로 선택했을 때만 아래코드 실행(데이터바인딩으로 인한 이벤트는 무시)
            if (cboCategory.SelectedIndex < 1) return;

            //제품의전체 목록이 없는 경우 제품정보를 조회
            if(prodAllList == null)
            {
                OrderService service = new OrderService();
                prodAllList = service.GetProductAllList();
            }
            //제품 전체 목록에서 선택된 가테고리에 해당하는 제품만 콤보바인딩
            List<ComboItemVO> list = (from product in prodAllList
                                      where product.CategoryID == Convert.ToInt32(cboCategory.SelectedValue)
                                      select new ComboItemVO {Code = product.ProductID, )
                                      
        }
    }
}
