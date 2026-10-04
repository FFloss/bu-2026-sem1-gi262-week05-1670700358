using UnityEngine;
using System.Collections.Generic;
using System;

namespace Assignment
{

    public interface IAssignment
    {
        #region Lecture 
        /// <summary>
        /// เรียงลำดับตัวเลขจากน้อยไปมากโดยใช้ Selection Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] LCT01_SelectionSortAscending(int[] numbers);

        /// <summary>
        /// เรียงลำดับตัวเลขจากน้อยไปมากโดยใช้ Bubble Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] LCT02_BubbleSortAscending(int[] numbers);

        /// <summary>
        /// เรียงลำดับตัวเลขจากน้อยไปมากโดยใช้ Insertion Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] LCT03_InsertionSortAscending(int[] numbers);

        #endregion

        #region Assignment

        /// <summary>
        /// เรียงลำดับตัวเลขจากมากไปน้อยโดยใช้ Selection Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int maxindex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] > numbers[maxindex])
                    {
                        maxindex = j;
                    }
                }
                // Swap the found maximum element with the first element
                (numbers[i], numbers[maxindex]) = (numbers[maxindex], numbers[i]);
            }
            return numbers;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขจากมากไปน้อยโดยใช้ Bubble Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        // swap temp and numbers[i]
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขจากมากไปน้อยโดยใช้ Insertion Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] < key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
            return numbers;
        }

        /// <summary>
        /// ค้นหาตัวเลขที่มีค่ามากเป็นอันดับสองใน array
        /// ให้เขียนโปรแกรมเพื่อค้นหาตัวเลขที่มีค่ามากเป็นอันดับสองจาก array ที่ได้รับเป็น input
        /// เช่น input ที่ได้รับมาคือ[1 2 3 4 5] ตัวเลขที่มีค่ามากเป็นอันดับสองคือ 4
        /// </summary>
        /// <param name="numbers"></param>
        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            Array.Sort(numbers);
            int n = numbers.Length;
            for (int i = n - 2; i >= 0; i--)
            {
                if (numbers[i] < numbers[n - 1])
                {
                    return numbers[i];
                }
            }

            return 0;
        }


        #endregion

        #region Extra

        /// <summary>
        /// ค้นหาความยาวชุดตัวเลขที่เรียงลำดับติดต่อกันที่ยาวที่สุด
        /// ให้เขียนโปรแกรมเพื่อค้นหาความยาวของชุดตัวเลขที่เรียงลำดับติดต่อกันที่ยาวที่สุดจาก array ที่ได้รับเป็น input
        /// ตัวอย่างความยาวชุดตัวเลขที่เรียงลำดับติดต่อกันที่ยาวที่สุด เช่น input ที่ได้รับมาคือ[1 9 3 10 4 20 2] เมื่อนำมาเรียงจากน้อยไปมากแล้วจะได้เป็น[1 2 3 4 9 10 20]
        /// ซึ่งเราจะได้ชุดตัวเลขย่อยๆที่เรียง 3 ชุดคือ
        /// [1 2 3 4]
        /// [9 10]
        /// [20]
        /// จะเห็นว่า[1 2 3 4] มีความยาวเท่ากับ4 ซึ่งเป็นชุดตัวเลขที่ยาวที่สุดเมื่อเทียบกับ 2 ชุดที่เหลือ
        /// ดังนั้นเราสามารถบอกได้ว่าชุดตัวเลขนี้[1 9 3 10 4 20 2] มี longest consecutive sequence ความยาวเท่ากับ 4
        /// </summary>
        /// <param name="numbers"></param>
        public int EX01_FindLongestConsecutiveSequence(int[] numbers);

        #endregion 
    }
}
