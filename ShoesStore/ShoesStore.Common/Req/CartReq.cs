﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesStore.Common.Req
{
    public class CartReq
    {
       

        public int CartId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedAt { get; set; }


    }
}
