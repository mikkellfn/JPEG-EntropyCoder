﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPEG_EntropyCoder.Components {
    public class EOBComponent : EntropyComponent {
        public EOBComponent(SimpleBitVector16 huffmanTreePath, byte huffmanLeafHexValue)
            : base(huffmanTreePath, huffmanLeafHexValue) { }
    }
}
