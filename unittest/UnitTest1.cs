﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using c7202312_Component2;
using System.Windows.Forms;
namespace unittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Move()
        {
            Form1 form = new Form1();
            var x = form.position_Xaxis;
            var y = form.position_Yaxis;
            form.pen_to_move(10, 20);
            bool eql = false;
            if (x != form.position_Xaxis && y != form.position_Yaxis)
                eql = true;
            Assert.IsTrue(eql);
        }

        [TestMethod]
        public void Draw()
        {
            var form = new Form1();
            var x = form.position_Xaxis;
            var y = form.position_Yaxis;
            form.pentodraw(10, 20);
            bool eql = false;
            if (x != form.position_Xaxis && y != form.position_Yaxis)
                eql = true;
            Assert.IsTrue(eql);
        }



        [TestMethod]
        public void Rectangle()
        {
            var form = new Form1();
            form.rectangle_draw(1, 2, 3, 4);
            Assert.IsTrue(form.drawing);
        }

        [TestMethod]
        public void Circle()
        {
            var form = new Form1();
            form.circle_draw(0, 0, 4);
            Assert.IsTrue(form.drawing);
        }

        [TestMethod]
        public void Triangle()
        {
            var form = new Form1();
            form.triangle_draw(0, 0, 23, 34);
            Assert.IsTrue(form.drawing);
        }
        /*
        [TestMethod]
        
        public void Execute()
        {
            var form = new Form1();
            object a = new object();
            EventArgs b = new EventArgs();
            form.button2_Click(a, b);
            Assert.IsTrue(form.execute);

        }
        */

        [TestMethod]
        public void Reset()
        {
            var form = new Form1();
            form.reset();
            Assert.IsTrue(form.reset_bool);

        }

        [TestMethod]
        public void Clear()
        {
            var form = new Form1();
            form.clear();
            Assert.IsTrue(form.clearing);

        }

        [TestMethod]
        public void Load()
        {
            var form = new Form1();
            object a = new object();
            EventArgs b = new EventArgs();
            form.loadToolStripMenuItem_Click(a, b);
            Assert.IsTrue(form.loading);
        }

        [TestMethod]
        public void Save()
        {
            var form = new Form1();
            object a = new object();
            EventArgs b = new EventArgs();
            form.loadToolStripMenuItem_Click(a, b);
            Assert.IsTrue(form.loading);
        }


    }
}
