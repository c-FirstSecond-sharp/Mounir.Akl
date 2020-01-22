using Abstracts;
using Interfaces;
using Patterns;
using System;
//using Windows.UI.Xaml;

namespace KeyClick.Main_Code_pool_branch
{
    public class AMNamed<B,P,T>:AM<P> where P : Construct 
    {
        internal string ThisTypeName
        {
            get
            {
                return _thisTypeName;
            }

          // set { _typeName = value; }
        }
        string _thisTypeName;
        string _pTypeName;
        internal string PTypeName
        {
            get
            {
                return _pTypeName;
            }
          //  set { _containedTypeName = value; }

        }
        string _bTypeName;
        internal string BTypeName
        {
            get
            {
                return _bTypeName;
            }
        //    set { _interFaceTypeName = value; }

        }
        string _prefix;
        internal string Prefix
        {
            get
            {
                return _prefix;
            }
            set { _prefix = value; }
         
        }

    
        string _fontFamily;//"Comic Sans"
        internal string FontFamily
        {
            get
            {
                return _fontFamily;
            }
            set { _fontFamily = value; }
            
        }
        
        bool _readonly;
        internal bool Readonly
        {
            get
            {
                return _readonly;
            }

            set
            {
                _readonly = value;
            }
        }
        string  _tTypeName;
        public string _TTypeName
        {
            get
            {
                return _tTypeName;
            }

         
        }
        T _value;
        public T Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }

       
        
        public AMNamed()
        {
            _tTypeName = typeof(T).AssemblyQualifiedName;
            _bTypeName = typeof(B).AssemblyQualifiedName;
            _pTypeName = typeof(P).AssemblyQualifiedName;
            //_thisTypeName = Cell<A, U, P, N, Construct>();
            _thisTypeName = this.GetType().AssemblyQualifiedName;
        }
        public  void Set<B, S,U>(AMNamed<B, S,U> uIType) where B : Construct where S : Construct
        {
            if (Is(uIType.Get().GetType()) || IsSubclass(uIType.Get().GetType()))
            {
                // B asTyp = (B)(uIType.Get() as B);
                //FrameworkElement asType = uIType as FrameworkElement;
                Set(uIType.Get() as  P);
                // Set((T)asTyp);
             //   Content = asTyp as T;
            }
            //else if (Content.Get().GetType().Equals(uIType.Get().GetType()))
            //{
            //    // B asTyp = (B)(uIType.Get() as B);
            //    //FrameworkElement asType = uIType as FrameworkElement;
            //    Content.Set(uIType.Get() as T);
            //    // Set((T)asTyp);
            //    //   Content = asTyp as T;
            //}


            //else if (((typeof(T)).Equals((uIType as IConstructable).ContentType())) || (IsSubclass(uIType.ContentType())))
            //{

            //    object asType =((object)(uIType as IConstructable).Get());// AMNamed<FrameworkElement, AGraphics> AMNamed<FrameworkElement, APanel>

            //    Set((T)asType);
            //}
            //else if (_content == null && typeof(T).GetTypeInfo().IsSubclassOf(typeof(L)) && (typeof(U).GetTypeInfo().IsSubclassOf(typeof(L))))
            //{
            //    L asType = (uIType as object) as L;


            //    Set(asType);
            //}
        }
        internal string IndexedName(int index)
        {
           return  _prefix + index+ Name;
        }
    
    }
}
