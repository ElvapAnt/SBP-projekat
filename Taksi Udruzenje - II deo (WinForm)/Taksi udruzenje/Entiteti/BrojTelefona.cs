﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksi_Udruzenje.Entiteti
{
    public class BrojTelefona
    {
        public virtual int Id { get; protected set; }
        public virtual string BrTel { get; set; }
        public virtual RedovnaMusterija PripadaRedovnojMusteriji { get; set; }

    }
}
