using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesHomework {
    class Sqr : Rect {

        public override string Print() { //make notes why this is ovveride 
            return "Sqr";
        }

        public Sqr() : base() { }

        public Sqr(int s1) : base(s1, s1) { }
    }
}
