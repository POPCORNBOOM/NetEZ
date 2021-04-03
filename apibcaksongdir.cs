using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEZ
{
    class apibcaksongdir
    {

        public class Data
        {

            /// <summary>
            /// 
            /// </summary>
            public string url { get; set; }

        }

        public class Rootd
        {
            /// <summary>
            /// 
            /// </summary>
            public List<Data> data { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int code { get; set; }
        }

    }
}
