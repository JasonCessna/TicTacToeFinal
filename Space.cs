using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicTacToe
{
    public class Space 
    {
        public int leftNodeX  { get; set; }
        public int rightNodeX { get; set; }
        public int topNodeX { get; set; }
        public int bottomNodeX { get; set; }
        public int topLeftNodeX { get; set; }
        public int topRightNodeX { get; set; }
        public int bottomLeftNodeX { get; set; }
        public int bottomRightNodeX { get; set; }
        public int leftNodeO { get; set; }
        public int rightNodeO { get; set; }
        public int topNodeO { get; set; }
        public int bottomNodeO { get; set; }
        public int topLeftNodeO { get; set; }
        public int topRightNodeO { get; set; }
        public int bottomLeftNodeO { get; set; }
        public int bottomRightNodeO { get; set; }
        public int weightX { get; set; }
        public int weightO { get; set; }
        public string spaceName  { get; set; }
        public char owner { get; set; }
       // int compareToO(Space obj);
        //int compareToX(Space obj);

        /*public int CompareTo(Space obj)
        {
            Space orderToCompare = obj as Space;
            if (orderToCompare.weightO < weightO)
            {
                return 1;
            }
            if (orderToCompare.weightO > weightO)
            {
                return -1;
            }
            return 0;
        }
            int CompareToX(Space obj)
        {
            Space orderToCompare = obj as Space;
            if (orderToCompare.weightX < weightX)
            {
                return 1;
            }
            if (orderToCompare.weightX > weightX)
            {
                return -1;
            }            
            return 0;
        }*/

        public Space(Space space)
        {
            this.spaceName = space.spaceName;
            this.owner = space.owner;
        }
        public Space(string name) 
        {
            spaceName = name;
            leftNodeX = 0;
            rightNodeX = 0;
            topNodeX = 0;
            bottomNodeX = 0;
            topLeftNodeX = 0;
            topRightNodeX = 0;
            bottomLeftNodeX = 0;
            bottomRightNodeX = 0;
            leftNodeO = 0;
            rightNodeO = 0;
            topNodeO = 0;
            bottomNodeO = 0;
            topLeftNodeO = 0;
            topRightNodeO = 0;
            bottomLeftNodeO = 0;
            bottomRightNodeO = 0;
            weightX = 0;
            weightO = 0;
            owner = 'e';
            
        }
        //getters and setters
        public string SpaceName
        {
            get
            { return spaceName; }
            set
            { spaceName = value; }
        }
        public int LeftNodeX
        {
            get { return leftNodeX; }
            set { leftNodeX = value; }
        }

        public int RightNodeX
        {
            get { return rightNodeX; }
            set { rightNodeX = value; }
        }
        public int TopNodeX
        {
            get { return topNodeX; }
            set { topNodeX = value; }
        }
        public int BottomNodeX
        {
            get { return bottomNodeX; }
            set { bottomNodeX = value; }
        }
        public int TopLeftNodeX
        {
            get { return topLeftNodeX; }
            set { topLeftNodeX = value; }
        }
        public int TopRightNodeX
        {
            get { return topRightNodeX; }
            set { topRightNodeX = value; }
        }
        public int BottomLeftNodeX
        {
            get { return bottomLeftNodeX; }
            set { bottomLeftNodeX = value; }
        }
        public int BottomRightNodeX
        {
            get { return bottomRightNodeO; }
            set { bottomRightNodeX = value; }
        }
        public int LeftNodeO
        {
            get { return leftNodeO; }
            set { leftNodeO = value; }
        }

        public int RightNodeO
        {
            get { return rightNodeO; }
            set { rightNodeO = value; }
        }
        public int TopNodeO
        {
            get { return topNodeO; }
            set { topNodeO = value; }
        }
        public int BottomNodeO
        {
            get { return bottomNodeO; }
            set { bottomNodeO = value; }
        }
        public int TopLeftNodeO
        {
            get { return topLeftNodeO; }
            set { topLeftNodeO = value; }
        }
        public int TopRightNodeO
        {
            get { return topRightNodeO; }
            set { topRightNodeO = value; }
        }
        public int BottomLeftNodeO
        {
            get { return bottomLeftNodeO; }
            set { bottomLeftNodeO = value; }
        }
        public int BottomRightNodeO
        {
            get { return bottomRightNodeO; }
            set { bottomRightNodeO = value; }
        }
        public int WeightX
        {
            get { return weightX; }
            set { weightX = value; }
        }
        public int WeightO
        {
            get { return weightO; }
            set { weightO = value; }
        }
        public char Owner
        {
            get { return owner; }
            set { owner = value; }
        }

       
    }
}

/*
            this.a1.BackColor = System.Drawing.Color.Silver;
            this.a1.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.a1.Location = new System.Drawing.Point(11, 37);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 75);
            this.a1.TabIndex = 1;
            this.a1.Text = "\\/ a1";
            this.a1.UseVisualStyleBackColor = false;
            this.a1.Click += new System.EventHandler(this.button_Click);*/