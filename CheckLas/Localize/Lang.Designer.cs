﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheckLas.Localize {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Lang {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Lang() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CheckLas.Localize.Lang", typeof(Lang).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error in the Curve section.
        /// </summary>
        public static string Curve {
            get {
                return ResourceManager.GetString("Curve", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на There is no section Curve.
        /// </summary>
        public static string CurveNotFound {
            get {
                return ResourceManager.GetString("CurveNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error in the ASCII section of the log data.
        /// </summary>
        public static string Data {
            get {
                return ResourceManager.GetString("Data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The number of listed curves in the Curve section does not correspond to the number of columns in the ASCII log data section.
        /// </summary>
        public static string DataCurveCount {
            get {
                return ResourceManager.GetString("DataCurveCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на No section ASCII log data.
        /// </summary>
        public static string DataNotFound {
            get {
                return ResourceManager.GetString("DataNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на File verification was successful.
        /// </summary>
        public static string ErrorNotFound {
            get {
                return ResourceManager.GetString("ErrorNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на No files to analyze.
        /// </summary>
        public static string FilesNotFound {
            get {
                return ResourceManager.GetString("FilesNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error in the Parameters section.
        /// </summary>
        public static string Parameters {
            get {
                return ResourceManager.GetString("Parameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error in the version section of the file.
        /// </summary>
        public static string Version {
            get {
                return ResourceManager.GetString("Version", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на There is no file version section.
        /// </summary>
        public static string VersionNotFound {
            get {
                return ResourceManager.GetString("VersionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Warning.
        /// </summary>
        public static string Warning {
            get {
                return ResourceManager.GetString("Warning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error in the Well section.
        /// </summary>
        public static string Well {
            get {
                return ResourceManager.GetString("Well", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Missing Well section.
        /// </summary>
        public static string WellNotFound {
            get {
                return ResourceManager.GetString("WellNotFound", resourceCulture);
            }
        }
    }
}