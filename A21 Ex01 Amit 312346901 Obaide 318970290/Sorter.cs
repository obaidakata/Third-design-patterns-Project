using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Amit_312346901_Obaide_318970290
{
    public class Sorter
    {
        public Func<LikerData, LikerData, bool> ShouldSwapStrategyMethod { get; set; }

        public void Sort(List<LikerData> i_Array)
        {
            for (int g = i_Array.Count / 2; g > 0; g /= 2)
            {
                for (int i = g; i < i_Array.Count; i++)
                {
                    for(int j = i - g; j >= 0; j -= g)
                    {
                        if(ShouldSwapStrategyMethod.Invoke(i_Array[j], i_Array[j + g]))
                        {
                            LikerData first = i_Array[j];
                            LikerData second = i_Array[j + g];
                            swap(ref first, ref second);
                            i_Array[j] = first;
                            i_Array[j + g] = second;
                        }
                    }
                }
            }
        }

        private void swap(ref LikerData data1, ref LikerData data2)
        {
            LikerData temp = data1;
            data1 = data2;
            data2 = temp;
        }
    }
}