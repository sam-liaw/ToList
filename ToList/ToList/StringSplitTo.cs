using System;
using System.Collections.Generic;
using System.Reflection;

namespace ToList
{
    class StringSplitTo
    {
        /// <summary>
        /// 字串透過分割符號付值給 Property 變數
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <param name="propertyNameArray"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static T StringSplitToProperty<T>(string str, string[] propertyNameArray, params char[] separator)
        {
            if (string.IsNullOrEmpty(str))
            {
                return default;
            }

            if (propertyNameArray.Length <= 0)
            {
                return default;
            }

            if (separator.Length <= 0)
            {
                return default;
            }

            T class_ = (T)Activator.CreateInstance(typeof(T));

            string[] strArray = str.Split(separator);

            var type_ = class_.GetType();
            PropertyInfo[] pia_ = type_.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            List<PropertyInfo> pis_ = new List<PropertyInfo>(pia_);

            int index_ = 0;
            List<string> keys_ = new List<string>(propertyNameArray);
            keys_.ForEach(x => {
                if (index_ < strArray.Length)
                {
                    pis_.ForEach(y => {
                        if (x == y.Name)
                        {
                            y.SetValue(class_, strArray[index_]);
                        }
                    });
                }
                index_++;
            });

            return class_;
        }

        /// <summary>
        /// 字串透過分割符號付值給 Field 變數
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <param name="fieldNameArray"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static T StringSplitToField<T>(string str, string[] fieldNameArray, params char[] separator)
        {
            if (string.IsNullOrEmpty(str))
            {
                return default;
            }

            if (fieldNameArray.Length <= 0)
            {
                return default;
            }

            if (separator.Length <= 0)
            {
                return default;
            }

            T class_ = (T)Activator.CreateInstance(typeof(T));

            string[] strArray = str.Split(separator);

            var type_ = class_.GetType();
            FieldInfo[] fia_ = type_.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            List<FieldInfo> pis_ = new List<FieldInfo>(fia_);

            int index_ = 0;
            List<string> keys_ = new List<string>(fieldNameArray);
            keys_.ForEach(x => {
                if (index_ < strArray.Length)
                {
                    pis_.ForEach(y => {
                        if (x == y.Name)
                        {
                            y.SetValue(class_, strArray[index_]);
                        }
                    });
                }
                index_++;
            });

            return class_;
        }
    }
}
