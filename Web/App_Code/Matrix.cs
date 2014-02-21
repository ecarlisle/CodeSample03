using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace number_matrix_exercise.App_Code
{
	public class Matrix
	{
		private List<int> numList;
		private int cols;
		private int rows;

		public int largestProduct = 0;
		public int[] largestMultiplierIndices = new int[4]{0,0,0,0};


		// Populate private local variables.
		public void init(int[] arr, int w, int h){
			this.cols = w;
			this.rows = h;
			this.numList = new List<int>(arr);
		}

		// Function for populating largestProduct and numberIndexes.
		public int findLargestProduct() {
			
			// Integer to track what row we're on.
			int currentRow = 1;

			// Iterate over the list of matrix numbers.
			for (int i=0; i < numList.Count; i++){

				// If the number is in the top 3 or bottom 3 rows...
				if (i < this.cols*3 || i >= rows*cols-cols*3){
					
					// If the number is 4 cols from the end of the row.
					if (i < currentRow * cols - 3){
						calculateHorizontalRight(i);
					}

				} else {

					// If the number is 4 cols from the end of the row or past the first 3 columns
					if (i < currentRow * cols - 3 && i >= (currentRow-1) * cols + 3)
					{
						calculateOctagonal(i);
					}

				}

				// Set the current row at the right times.
				if (i == currentRow * this.rows - 1) {
					currentRow++;
				}


			}

			return currentRow;
		}

		private void calculateHorizontalRight(int i){
			checkLargestValues(i,i+1,i+2,i+3);
		}

		private void calculateHorizontalLeft(int i)
		{
			checkLargestValues(i, i - 1, i - 2, i - 3);
		}

		private void calculateVerticalUp(int i)
		{
			checkLargestValues(i, i - this.cols, i - this.cols * 2, i - this.cols * 3);
		}

		private void calculateVerticalDown(int i)
		{
			checkLargestValues(i, i + this.cols, i + this.cols * 2, i + this.cols * 3);
		}

		private void calculateDiagonalUpLeft(int i)
		{
			checkLargestValues(i, i - this.cols - 1, i - this.cols * 2 - 2, i - this.cols * 3 - 3);
		}

		private void calculateDiagonalUpRight(int i)
		{
			checkLargestValues(i, i - this.cols, i - this.cols * 2, i - this.cols * 3);
		}

		private void calculateDiagonalDownLeft(int i)
		{
			checkLargestValues(i, i - this.cols - 1, i - this.cols * 2 - 2, i - this.cols * 3 - 3);
		}

		private void calculateDiagonalDownRight(int i)
		{
			checkLargestValues(i, i + this.cols, i + this.cols * 2, i + this.cols * 3);
		}


		private void calculateOctagonal(int i){
			calculateHorizontalRight(i);
			calculateHorizontalLeft(i);
			calculateVerticalUp(i);
			calculateVerticalDown(i);
			calculateDiagonalUpLeft(i);
			calculateDiagonalUpRight(i);
			calculateDiagonalDownLeft(i);
			calculateDiagonalDownRight(i);
		}


		private void checkLargestValues(int i1, int i2, int i3, int i4)
		{
			int product = numList[i1] * numList[i2] * numList[i3] * numList[i4];

			if (product > this.largestProduct) {
				this.largestProduct = product;
				this.largestMultiplierIndices.SetValue(i1, 0);
				this.largestMultiplierIndices.SetValue(i2, 1);
				this.largestMultiplierIndices.SetValue(i3, 2);
				this.largestMultiplierIndices.SetValue(i4, 3);
			}
		}

	}
}