namespace InterfaceSegragation
{
        public interface IJsonSavable
        {
            string Serialise(string id);
        }

        public interface IBinaryFormatterSavable
        {
            object Serialise(string id);
        }  
        
        public interface IByteArraySavable
        {
            byte[] Serialise(string id);
        }    
        
        public interface ITypeSavable<T>
        {
            T Serialise(string id);
        }
}