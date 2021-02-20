﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PaintOOP.Model
{
    class ListFigure : List<IFigure>
    {

        public List<IFigure> undoFigures { get;}

        public ListFigure() {
            this.undoFigures = new List<IFigure>();
        }

        public void undo()
        {
            if (this.Count != 0) {
                this.undoFigures.Add(this.Last());
                this.RemoveAt(this.Count - 1);
            }
            
        }

        public void redo()
        {
            if (this.undoFigures.Count != 0)
            {
                this.Add(this.undoFigures.Last());
                this.undoFigures.RemoveAt(this.undoFigures.Count - 1);
            }
            
        }

        public void setRedoNil()
        {
            this.undoFigures.Clear();
        }

    }
}
