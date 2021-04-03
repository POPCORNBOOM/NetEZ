using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEZ
{
    public class ArtistsItem
    {
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
    }
    public class SongsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 我愛你
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List <ArtistsItem > artists { get; set; }
    }
    public class Data
        {
            /// <summary>
            /// 
            /// </summary>
            public List<SongsItem> songs { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int songCount { get; set; }
        }

        public class Author
        {
            /// <summary>
            /// 
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 由Alone88提供的免费API 服务，官方文档：www.alapi.cn
            /// </summary>
            public string desc { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public int code { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string msg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Data data { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Author Author { get; set; }
        }

    }

