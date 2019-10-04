using System;
using System.Collections.Generic;
using System.Linq;

namespace ToList
{
    public class ContainerToList
    {
        /// <summary>
        /// Array 轉 List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public List<T> ArrayToList<T>(T[] array)
        {
            // 引用 System.Linq 就能利用  ToList() 轉成 List 
            return array.ToList<T>();
        }

        /// <summary>
        /// List 轉 Array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public T[] ListToArray<T>(List<T>  list)
        {
            // 引用 System.Linq 就能利用  ToArray() 轉成 Array 
            return list.ToArray<T>();
        }

        /// <summary>
        /// Dictionary 轉 List
        /// </summary>
        /// <typeparam name="KEY"></typeparam>
        /// <typeparam name="VALUE"></typeparam>
        /// <param name="dic"></param>
        /// <returns></returns>
        public List<VALUE> DictionaryToList<KEY, VALUE>(Dictionary<KEY, VALUE> dic)
        {
            return dic.Values.ToList();
        }

        /// <summary>
        /// Dictionary 轉 Array
        /// </summary>
        /// <typeparam name="KEY"></typeparam>
        /// <typeparam name="VALUE"></typeparam>
        /// <param name="dic"></param>
        /// <returns></returns>
        public VALUE[] DictionaryToArray<KEY, VALUE>(Dictionary<KEY, VALUE> dic)
        {
            return dic.Values.ToArray();
        }
    }
}
