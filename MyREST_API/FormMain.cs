using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyAPICOM;
using static ToolUtilities.Network.ProtocolType;

namespace MyREST_API
{
    /// <summary>
    /// メインフォームクラス
    /// </summary>
    public partial class FormMain : Form
    {
        MyAPI APIObj = new MyAPI( "127.0.0.1", HTTP, 8000 );

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// GETデータ取得ボタンクリック時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnGETData_Click( object sender, EventArgs e )
        {
            try {
                dgvGetData.Rows.Clear();


                var item = await APIObj.ReadItemData( (int)nudGetDataID.Value );

                dgvGetData.Rows.Add( item.ID.ToString(), item.Name, item.Price.ToString(), item.Company, item.Remarks );

            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message );
            }
        }

        /// <summary>
        /// GETデータリスト取得ボタンクリック時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnGETDataList_Click( object sender, EventArgs e )
        {
            try {
                bool all = false;

                if ( rdbGetDataListALLTrue.Checked == true ) {
                    all = true;
                }

                dgvGetDataList.Rows.Clear();

                List<ItemData> list = await APIObj.ReadItemDataList( txtGetDataListCompany.Text, all );

                foreach ( var item in list ) {
                    dgvGetDataList.Rows.Add( item.ID.ToString(), item.Name, item.Price.ToString(), item.Company, item.Remarks );
                }

            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message );
            }
        }

        /// <summary>
        /// POSTボタン押下時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnPOST_Click( object sender, EventArgs e )
        {
            try {
                HttpResponseMessage mes = await APIObj.AddItemData( txtPOSTName.Text, ( int )numPOSTPrice.Value, txtPOSTCompany.Text, txtPOSTRemarks.Text );

            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message );
            }
        }

        /// <summary>
        /// PUTボタン押下時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnPUT_Click( object sender, EventArgs e )
        {
            try {
                HttpResponseMessage mes = await APIObj.UpdateItemData( ( int )nudPUTID.Value, txtPUTName.Text, ( int ) numPUTPrice.Value, txtPUTCompany.Text, txtPUTRemarks.Text );

            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message );
            }
        }

        private async void btnDELETE_Click( object sender, EventArgs e )
        {
            try {
                HttpResponseMessage mes = await APIObj.DeleteItemData( ( int ) nudDELETEID.Value );

            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message );
            }
        }
    }
}
