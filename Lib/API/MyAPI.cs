using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Net.Http;

using ToolUtilities.Network;
using static ToolUtilities.Network.ProtocolType;
using System.Linq.Expressions;

namespace MyAPICOM
{
    public class MyAPI : RestAPICom
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="WC">W/C</param>
        /// <param name="strHTTPSrvIP">HTTPサーバーIPアドレス</param>
        /// <param name="ProtocolTypeVal">通信プロトコル種類</param>
        /// <param name="PortNo">HTTPポート番号</param>
        public MyAPI( string strHTTPSrvIP, ProtocolType ProtocolTypeVal = HTTP, int PortNo = 80 ) : base( strHTTPSrvIP, ProtocolTypeVal, PortNo )
        {
            this.WellKnownTopDir = "";
        }

        /// <summary>
        /// Itemデータ取得
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public async Task<ItemData> ReadItemData( int id )
        {
            try {
                List<string> strDirs = new List<string>();

                if ( PortNo == 80 || PortNo == 443 ) {                  //  Well knownポートの場合
                    if ( WellKnownTopDir != "" ) {
                        strDirs.Add( WellKnownTopDir );
                    }
                }

                strDirs.AddRange( new string[] { "api", "item", id.ToString() } );

                string response    = await GetCmd( strDirs, DirLastSlashNone: true );       //  GET通信
                ItemData reqData = null;

                if ( response != "" ) {                 //  レスポンスデータがある場合id
                    reqData = JsonSerializer.DeSerialize<ItemData>( response );             //  取得したJSONデータをクラスオブジェクトに変換
                }

                return ( reqData );

            } catch {
                throw;
            }
        }

        /// <summary>
        /// Itemデータリスト取得
        /// </summary>
        /// <param name="company">会社名</param>
        /// <returns></returns>
        public async Task<List<ItemData>> ReadItemDataList( string company, bool all = false )
        {
            try {
                List<string> strDirs = new List<string>();

                if ( PortNo == 80 || PortNo == 443 ) {                  //  Well knownポートの場合
                    if ( WellKnownTopDir != "" ) {
                        strDirs.Add( WellKnownTopDir );
                    }
                }


                string response = "";
                
                if ( all == false ) {   //  指定会社のデータ取得
                    strDirs.AddRange( new string[] { "api", "items", company } );
                    response = await GetCmd( strDirs, DirLastSlashNone: true );                               //  GET通信

                } else {                //  全データ取得
                    strDirs.AddRange( new string[] { "api", "items", "dummy" } );
                    Dictionary<string, string> dic = new Dictionary<string, string>();
                    dic.Add( "all", "true" );

                    response = await GetCmd( strDirs, dic, DirLastSlashNone: true );                               //  GET通信
                }
                
                List<ItemData> reqData = null;

                if ( response != "" ) {                 //  レスポンスデータがある場合id
                    reqData = JsonSerializer.DeSerializeToList<ItemData>( response );           //  取得したJSONデータをクラスオブジェクトに変換
                }

                return ( reqData );

            } catch {
                throw;
            }
        }

        /// <summary>
        /// Itemデータ追加
        /// </summary>
        /// <param name="name">商品名</param>
        /// <param name="price">価格</param>
        /// <param name="company">会社名</param>
        /// <param name="remarks">備考</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> AddItemData( string name, int price, string company, string remarks )
        {
            try {
                List<string> strDirs = new List<string>();

                if ( PortNo == 80 || PortNo == 443 ) {                  //  Well knownポートの場合
                    if ( WellKnownTopDir != "" ) {
                        strDirs.Add( WellKnownTopDir );
                    }
                }

                strDirs.AddRange( new string[] { "api", "item" } );     //  エンドポイント

                ItemData postData = new ItemData() {                    //  POSTデータオブジェクト
                    Name    = name,
                    Price   = price,
                    Company = company,
                    Remarks = remarks
                };

                string json = JsonSerializer.Serialize<ItemData>( postData );   //  JSON文字列に変換

                HttpResponseMessage resMessage = await PostCmd( strDirs, null, json, true );

                return ( resMessage );

            } catch {
                throw;
            }
        }

        /// <summary>
        /// Itemデータ追加
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">商品名</param>
        /// <param name="price">価格</param>
        /// <param name="company">会社名</param>
        /// <param name="remarks">備考</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> UpdateItemData( int id, string name, int price, string company, string remarks )
        {
            try {
                List<string> strDirs = new List<string>();

                if ( PortNo == 80 || PortNo == 443 ) {                  //  Well knownポートの場合
                    if ( WellKnownTopDir != "" ) {
                        strDirs.Add( WellKnownTopDir );
                    }
                }

                strDirs.AddRange( new string[] { "api", "item" } );     //  エンドポイント

                ItemData putData = new ItemData()                       //  PUTデータオブジェクト
                {                       
                    ID      = id,
                    Name    = name,
                    Price   = price,
                    Company = company,
                    Remarks = remarks
                };

                string json = JsonSerializer.Serialize<ItemData>( putData );   //  JSON文字列に変換

                HttpResponseMessage resMessage = await PutCmd( strDirs, null, json, true );

                return ( resMessage );

            } catch {
                throw;
            }
        }

        /// <summary>
        /// Itemデータ削除
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> DeleteItemData( int id )
        {
            try {
                List<string> strDirs = new List<string>();

                if ( PortNo == 80 || PortNo == 443 ) {                  //  Well knownポートの場合
                    if ( WellKnownTopDir != "" ) {
                        strDirs.Add( WellKnownTopDir );
                    }
                }

                strDirs.AddRange( new string[] { "api", "item", id.ToString() } );     //  エンドポイント

                HttpResponseMessage resMessage = await DeleteCmd( strDirs, null, true );

                return ( resMessage );

            } catch {
                throw;
            }
        }

    }

    /// <summary>
    /// Itemデータクラス
    /// </summary>
    [DataContract]
    public class ItemData
    {
        [DataMember]
        /// <summary>ID</summary>
        public int ID { get; set; }

        [DataMember]
        /// <summary>商品名</summary>
        public string Name { get; set; }

        [DataMember]
        /// <summary>価格</summary>
        public int Price { get; set; }

        [DataMember]
        /// <summary>会社</summary>
        public string Company { get; set; }

        [DataMember]
        /// <summary>備考</summary>
        public string Remarks { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ItemData()
        {

        }
    }
}
