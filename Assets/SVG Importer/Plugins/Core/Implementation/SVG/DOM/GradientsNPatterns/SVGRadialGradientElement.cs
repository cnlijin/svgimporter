

using UnityEngine;
using System.Collections.Generic;

namespace SVGImporter.Rendering 
{
    using Document;
    using Utils;

    public class SVGRadialGradientElement : SVGGradientElement
    {
        private SVGLength _cx;
        private SVGLength _cy;
        private SVGLength _r;
        private SVGLength _fx;
        private SVGLength _fy;
      
        public SVGLength cx
        {
            get { return _cx; }
        }

        public SVGLength cy
        {
            get { return _cy; }
        }

        public SVGLength r
        {
            get { return _r; }
        }

        public SVGLength fx
        {
            get { return _fx; }
        }

        public SVGLength fy
        {
            get { return _fy; }
        }
      
        public SVGRadialGradientElement(SVGParser xmlImp, Node node) : base(xmlImp, node)
        {
            string temp;
            temp = _attrList.GetValue("cx");
            _cx = new SVGLength((temp == "") ? "50%" : temp);

            temp = _attrList.GetValue("cy");
            _cy = new SVGLength((temp == "") ? "50%" : temp);

            temp = _attrList.GetValue("r");
            _r = new SVGLength((temp == "") ? "50%" : temp);

            temp = _attrList.GetValue("fx");
            _fx = new SVGLength((temp == "") ? "50%" : temp);

            temp = _attrList.GetValue("fy");
            _fy = new SVGLength((temp == "") ? "50%" : temp);
        }
    }
}
