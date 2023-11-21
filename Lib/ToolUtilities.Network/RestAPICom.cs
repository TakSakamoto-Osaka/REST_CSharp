﻿using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static ToolUtilities.Network.ProtocolType;

namespace ToolUtilities.Network
{
    /// <summary>
    /// 通信プロトコル種類
    /// </summary>
    public enum ProtocolType
    {
        /// <summary>HTTP通信</summary>
        HTTP,

        /// <summary>HTTPS通信</summary>
        HTTPS,
    }

    /// <summary>
    /// REST API 通信クラス
    /// </summary>
    public class RestAPICom
    {
        /// <summary>サーバーIPアドレス</summary>
        public string HTTPSrvIP { get; private set; }

        /// <summary>通信プロトコル種類</summary>
        public ProtocolType ProtocolTypeVal { get; private set; }

        /// <summary>HTTPポート番号</summary>
        public int PortNo { get; private set; }

        /// <summary>WellKnownポートでアクセス時のトップディレクトリ</summary>
        public string WellKnownTopDir { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="HTTPSrvIP">HTTPサーバーIPアドレス</param>
        /// <param name="ProtocolType">通信プロトコル種類</param>
        /// <param name="PortNo">HTTPポート番号</param>
        public RestAPICom( string HTTPSrvIP, ProtocolType ProtocolTypeVal = HTTP, int PortNo = 80 )
        {
            this.HTTPSrvIP       = HTTPSrvIP;               //  HTTPサーバーIPアドレス
            this.ProtocolTypeVal = ProtocolTypeVal;         //  通信プロトコル種類
            this.PortNo          = PortNo;                  //  HTTPポート番号
        }

        /// <summary>
        /// GETコマンドを用いて 指定のURIのデータ取得
        /// </summary>
        /// <param name="strDir">ディレクトリ</param>
        /// <param name="strParams">パラメータ</param>
        /// <returns></returns>
        public async Task<string> GetCmd( List<string> strDirs, Dictionary<string,string> strParams = null, bool DirLastSlashNone = false )
        {
            //  HTTPプロトコルのGETコマンドを用いて URLにアクセス
            try {
                string strUri = UriCreate( strDirs, strParams, DirLastSlashNone );

                using ( var client = new HttpClient() ) {                       //  HTTPクライアントオブジェクト生成
                    return ( await client.GetStringAsync( strUri ) );           //  GET通信
                }

            } catch {
                throw;
            }
        }
        
        /// <summary>
        /// PUTコマンドを用いて JSON文字列を送信する
        /// </summary>
        /// <param name="strDirs">ディレクトリ</param>
        /// <param name="strParams">パラメータ</param>
        /// <param name="strPutData">送信データ</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> PutCmd( List<string> strDirs, Dictionary<string,string> strParams = null, string strPutData = "", bool DirLastSlashNone = false )
        {
            //  HTTPプロトコルのPUTコマンドを用いて URLにアクセス
            try {
                string strUri = UriCreate( strDirs, strParams, DirLastSlashNone );

                using ( var client = new HttpClient() ) {                                       //  HTTPクライアントオブジェクト生成
                    var content = new StringContent( strPutData, Encoding.UTF8, @"application/json" );

                    HttpResponseMessage response = await client.PutAsync( strUri, content );    //  PUT通信

                    return ( response );
                }

            } catch {
                throw;
            }
        }

        /// <summary>
        /// POSTコマンドを用いて JSON文字列を送信する
        /// </summary>
        /// <param name="strDirs">ディレクトリ</param>
        /// <param name="strParams">パラメータ</param>
        /// <param name="strPostData">送信データ</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> PostCmd( List<string> strDirs, Dictionary<string, string> strParams = null, string strPostData = "", bool DirLastSlashNone = false )
        {
            //  HTTPプロトコルのPOSTコマンドを用いて URLにアクセス
            try {
                string strUri = UriCreate( strDirs, strParams, DirLastSlashNone );

                using ( var client = new HttpClient() ) {                                           //  HTTPクライアントオブジェクト生成
                    var content = new StringContent( strPostData, Encoding.UTF8, @"application/json" );

                    HttpResponseMessage response = await client.PostAsync( strUri, content );       //  POST通信

                    return ( response );
                }

            } catch {
                throw;
            }
        }

        /// <summary>
        /// DELETEコマンドを送信する
        /// </summary>
        /// <param name="strDirs">ディレクトリ</param>
        /// <param name="strParams">パラメータ</param>
        /// <param name="strPutData">送信データ</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> DeleteCmd( List<string> strDirs, Dictionary<string, string> strParams = null, bool DirLastSlashNone = false )
        {
            //  HTTPプロトコルのDELETEコマンドを用いて URLにアクセス
            try {
                string strUri = UriCreate( strDirs, strParams, DirLastSlashNone );

                using ( var client = new HttpClient() ) {                                       //  HTTPクライアントオブジェクト生成
                    HttpResponseMessage response = await client.DeleteAsync( strUri );    //  PUT通信

                    return ( response );
                }

            } catch {
                throw;
            }
        }

        /// <summary>
        /// URI文字列を生成する
        /// </summary>
        /// <param name="strDirs">ディレクトリ</param>
        /// <param name="strParams">パラメータ</param>
        /// <param name="DirLastSlashNone">ディレクトリ部最終スラッシュなし</param>
        /// <returns></returns>
        private string UriCreate( List<string> strDirs, Dictionary<string,string> strParams = null, bool DirLastSlashNone = false )
        {
            //  通信ポート番号生成
            string strPort = "";

            if ( ( ProtocolTypeVal == HTTP ) && ( PortNo != 80 ) ) {                //  HTTPで80番以外の場合
                strPort = ":" + PortNo.ToString();
            }

            if ( ( ProtocolTypeVal == HTTPS ) && ( PortNo != 443 ) ) {              //  HTTPSで443番以外の場合
                strPort = ":" + PortNo.ToString();
            }

            //  URIディレクトリ文字列生成
            string DirVal = "/";

            foreach ( var str in strDirs ) {
                DirVal += ( str + "/" );
            }

            if ( strParams == null && DirLastSlashNone == true ) {                  //  パラメータ部がなく、ディレクトリ部の最後のスラッシュを付加しない場合
                DirVal = DirVal.TrimEnd( '/' );                             //  最後のスラッシュを削除
            }

            //  パラメータ部文字列生成
            string ParamVal = "";

            if ( strParams != null ) {                      //  パラメータ指定がある場合
                ParamVal = "?";

                foreach ( var paramElm in strParams ) {
                    ParamVal += ( paramElm.Key + "=" + paramElm.Value + "&" );
                }

                ParamVal = ParamVal.TrimEnd( '&' );         //  末尾の & を取り除く
            }

            //  URI組み立て
            return ( ProtocolTypeVal.ToString().ToLower() + "://" + HTTPSrvIP + strPort + DirVal + ParamVal );
        }
    }
}
