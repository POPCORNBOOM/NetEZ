using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEZ
{
    class Apibacksearch
    {
        public class ArItem
        {
            /// <summary>
            /// 
            /// </summary>
            public int id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string name { get; set; }
        }


        public class ChargeInfoListItem
        {

            /// <summary>
            /// 0免费、1收费
            /// </summary>
            public int chargeType { get; set; }
        }
        public class Privilege
        {
            /// <summary>
            /// 
            /// </summary>
            public List<ChargeInfoListItem> chargeInfoList { get; set; }
        }
        public class SongsItem
        {
            /// <summary>
            /// 歌曲名称
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 歌曲id
            /// </summary>
            public int id { get; set; }

            /// <summary>
            /// 艺术家[]
            /// </summary>
            public List<ArItem> ar { get; set; }
            /// <summary>
            /// 优惠
            /// </summary>
            public Privilege privilege { get; set; }
        }
        public class Result
        {
            /// <summary>
            /// 歌曲列表[]
            /// </summary>
            public List<SongsItem> songs { get; set; }
            /// <summary>
            /// 歌曲数目
            /// </summary>
            public int songCount { get; set; }
        }
        public class Roota
        {
            /// <summary>
            /// 获取结果
            /// </summary>
            public Result result { get; set; }
            /// <summary>
            /// 错误码
            /// </summary>
            public int code { get; set; }
        }


    }
}
