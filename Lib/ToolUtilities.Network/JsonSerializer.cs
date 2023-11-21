using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace ToolUtilities.Network
{
    public class JsonSerializer
    {
        /// <summary>
        /// クラスオブジェクトをJSON文字列に変換
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="classObj"></param>
        /// <returns></returns>
        public static string Serialize<T>( T classObj )
        {
            try {
                using ( var ms = new MemoryStream() )                                   //  メモリストリーム生成
                using ( var sr = new StreamReader( ms ) ) {                             //  ストリームリーダー生成
                    var serializer = new DataContractJsonSerializer( typeof( T ) );
                    serializer.WriteObject( ms, classObj );
                    ms.Position = 0;

                    return( sr.ReadToEnd() );                                           //  JSON文字列生成
                }

            } catch {
                throw;
            }
        }

        /// <summary>
        /// JSON文字列をクラスオブジェクトに変換
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        public static T DeSerialize<T>( string response, Action<T> action = null )
        {
            try {
                byte[] bytes = Encoding.UTF8.GetBytes( response );          //  JSON文字列をバイト列に変換

                using ( MemoryStream ms = new MemoryStream( bytes ) ) {
                    T classObj = ( T ) Serializer<T>().ReadObject( ms );    //  メモリストリームを指定のクラスオブジェクトに変換

                    action?.Invoke( classObj );

                    return ( classObj );
                }

            } catch {
                throw;
            }
        }

        /// <summary>
        /// JSON文字列をリストオブジェクトに変換
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        public static List<T> DeSerializeToList<T>( string response )
        {
            try {
                byte[] bytes = Encoding.UTF8.GetBytes( response );          //  JSON文字列をバイト列に変換

                using ( MemoryStream ms = new MemoryStream( bytes ) ) {
                    List<T> listObj = ( List<T> ) SerializerList<T>().ReadObject( ms );    //  メモリストリームを指定のクラスオブジェクトに変換

                    return ( listObj );
                }

            } catch {
                throw;
            }
        }


        /// <summary>
        /// 通常用
        /// </summary>
        /// <typeparam name="T">任意の型</typeparam>
        /// <returns></returns>
        public static DataContractJsonSerializer Serializer<T>() => new DataContractJsonSerializer( typeof( T ), new DataContractJsonSerializerSettings
        {
            DateTimeFormat = new DateTimeFormat( "yyyy-MM-dd hh:mm:ss" ),
        } );

        /// <summary>
        /// Listオブジェクト用
        /// </summary>
        /// <typeparam name="T">任意の型</typeparam>
        /// <returns></returns>
        public static DataContractJsonSerializer SerializerList<T>() => new DataContractJsonSerializer( typeof( List<T> ), new DataContractJsonSerializerSettings
        {
            DateTimeFormat = new DateTimeFormat( "yyyy-MM-dd hh:mm:ss" ),
        } );

        /// <summary>
        /// Dictionaryオブジェクト用
        /// </summary>
        /// <typeparam name="TKey">任意の型</typeparam>
        /// <typeparam name="TVal">任意の型</typeparam>
        /// <returns></returns>
        private static DataContractJsonSerializer SerializerDictionary<TKey, TVal>() => new DataContractJsonSerializer( typeof( Dictionary<TKey, TVal> ), new DataContractJsonSerializerSettings
        {
            DateTimeFormat = new DateTimeFormat( "yyyy-MM-dd hh:mm:ss" ),
        } );
    }
}
