/*********************************************************
Author          - lavinds
Date Created    - 22-Jul-2018
**********************************************************
Sn      Author      Date            Comments
**********************************************************
1.      lavinds   13-Sep-2018       Initial draft of file 
*********************************************************/

#region Namespaces
using System;
using DataStructuresCsharp;
using Xunit;
#endregion

namespace DSCTest
{
    public class InsertTest
    {
        [Fact]
        public void BinartTreeInsertTest()
        {
            BinaryTree btObj = new BinaryTree();
            btObj.InsertData(5);
            btObj.InsertData(6);
            btObj.InsertData(7);
            btObj.InsertData(4);
            btObj.InsertData(3);
            btObj.InsertData(8);
        }        
    }
}