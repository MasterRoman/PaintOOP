using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintOOP.Model.PaintingModel;

namespace PaintOOP.Services
{
    public class PaintingProperty : IPaintingProperty
    {
        public LineConfiguration penProperty { get; set; }
        public FillConfiguration brushProperty { get; set; }
    }
}
