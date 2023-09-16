using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void TestDeterminantCalculation()
        {
            int[,] matrixData = new int[3 , 3]
            {
            {1, 1, 2},
            {3, 1, 2},
            {3, 1, 1}
            };

            Matrix matrix = new( matrixData );
            IDeterminantVisitor determinantVisitor = new DeterminantVisitor();

            int determinant = matrix.Accept( determinantVisitor );

            Assert.AreEqual( 2 , determinant );
        }

        [TestMethod]
        public void TestTransposeCalculation()
        {
            int[,] matrixData = new int[3 , 3]
            {
            {1, 1, 2},
            {3, 1, 2},
            {3, 1, 1}
            };

            Matrix matrix = new( matrixData );
            ITransposeVisitor transposeVisitor = new TransposeVisitor();

            Matrix transposedMatrix = matrix.Accept( transposeVisitor );

            int[,] expectedTransposedData = new int[3 , 3]
            {
            {1, 3, 3},
            {1, 1, 1},
            {2, 2, 1}
            };

            CollectionAssert.AreEqual( expectedTransposedData , transposedMatrix.Data );
        }
    }
}
