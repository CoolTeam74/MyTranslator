﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyTranslator.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MyTranslator.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на 	.model tiny
        ///	.code
        ///	.386
        ///	org 100h
        ///start:
        ///vvod1:					
        ///	xor eax,eax			
        ///	xor edx,edx			
        ///	call clrscr
        ///	mov ah,9			
        ///	mov dx,offset message1			
        ///	int 21h				
        ///	mov ah,08h					
        ///	int 21h				
        ///	cmp al,&apos;+&apos;			 
        ///	je cloj				
        ///	cmp al,&apos;-&apos;			
        ///	je vich				
        ///	cmp al,&apos;/&apos;
        ///	je dele				
        ///	cmp al,&apos;*&apos;
        ///	je rr1								
        ///	jmp rr				
        ///rr1:	jmp umnoj			
        ///rr:	cmp al,&apos;q&apos;			
        ///	je quit
        ///	cmp al,&apos;Q&apos;
        ///	je quit
        ///	jmp short vvod1				
        ///quit:	
        ///	ret				
        ///cloj:					
        ///	call clrscr			
        ///		
        ///	call aa1			
        ///	push dx				
        ///	call bb1			 [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string calc {
            get {
                return ResourceManager.GetString("calc", resourceCulture);
            }
        }
    }
}
