﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace editorDeGrafos
{
    /*
     * This class represent a kind of container for nodes in the graph structure as the relation
     * these are really the edges
     */
    public class NodeRef
    {

        #region NodeRefDeclarations
        /*DEFAULT CONSTANTS AND DECLARATIONS:*/

        #region FunctionalDeclarations
        protected int weight;//the weight that represents the relation
        protected Node nodo;// the node that is visited
        //TidyPair tidy;

        //for traversal and other methods
        protected Boolean activeNode = true;
        protected Boolean visited = false;

        protected char typeOfConection = 'u';

        protected int id;//every edge is unique

        #endregion

        #region GraphicalDeclarations



        #endregion

        #endregion

        #region NodeRefConstructors
        public NodeRef(int weight, Node nodo, char typeOfEdge, List<int> IDlist)
        {
            this.nodo = nodo;
            this.weight = weight;

            if (typeOfEdge == 'd')
            {
                this.typeOfConection = typeOfEdge;
            }
            this.id = Util.createID(IDlist);
        }
        //public NodeRef(int weight, Node nodo, TidyPair tidyPair, char typeOfEdge, List<int> IDlist)
        //{
        //    this.tidy = tidyPair;
        //    this.nodo = nodo;
        //    this.weight = weight;
        //    activeNode = false;            
        //    if (typeOfEdge == 'd')
        //    {
        //        this.typeOfConection = typeOfEdge;
        //    }
        //    this.Id = Util.createID(IDlist);
        //}

        //public NodeRef(int weight, Node nodo, TidyPair tidyPair, Boolean active, char typeOfEdge, List<int> IDlist)
        //{
        //    this.tidy = tidyPair;
        //    this.nodo = nodo;
        //    this.weight = weight;
        //    activeNode = active;

        //    if (typeOfEdge == 'd')
        //    {
        //        this.typeOfConection = typeOfEdge;  
        //    }
        //    this.Id = Util.createID(IDlist);
        //}


        #endregion

        #region NodeRefProperties
        /*******************************************************
        *                Geters and seters(Begin)               *
        *******************************************************/
        public char Type
        {
            get { return this.typeOfConection; }
        }

        public bool Directed
        {
            get
            {
                if (this.Type == 'd')
                {
                    return true;
                }
                return false;
            }

        }

        public bool Undirected
        {
            get
            {
                if (this.Type == 'u')
                {
                    return true;
                }
                return false;
            }

        }

        public int Id
        {
            get { return this.id; }
        }

        public Node Node
        {
            get { return this.nodo; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public Boolean Activation
        {
            get { return activeNode; }
            set { activeNode = value; }
        }

        public Boolean Visited
        {
            get { return visited; }
            set { visited = value; }
        }

        /*******************************************************
         *                Geters and seters(End)               *
         *******************************************************/
        #endregion

        #region NodeRefMethods
        /*******************************************************
         *                Methods(Begin)                       *
         *******************************************************/



        #endregion

        #region NodeRefEvents
        public void reset()
        {
            visited = false;
        }
        #endregion

    }//NodeRef.


   
      

}
