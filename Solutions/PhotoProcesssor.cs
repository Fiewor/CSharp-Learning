public partial class Program
{
    public class PhotoProcesssor
    {
        // define a delegate type
        // when defining delegates, we need to define the 'signature' of the method that this delegate will be responsible for calling

        //public delegate void PhotoFilterHandler(Photo photo);
        // an instance of this delegate can hold a pointer to a function or a group of functions that have the signature
        //public void Process(string path, PhotoFilterHandler filterHandler)
        public void Process(string path, Action<Photo> filterHandler)
        {
            //System.Action
            //System.Func
            var photo = Photo.Load(path);

            filterHandler(photo); // what this means is that this code does not know what filter will be applied. It's the responsibility of the client of the code to define the filters they want.

            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            photo.Save();
        }
    }
}