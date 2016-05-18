﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPEG_EntropyCoder.Components {
    public class ACComponent : EntropyValueComponent {
        public ACComponent(SimpleBitVector16 huffmanTreePath, byte huffmanLeafHexValue, SimpleBitVector16 amplitude) 
            : base(huffmanTreePath, huffmanLeafHexValue, amplitude) { }
    }
}
