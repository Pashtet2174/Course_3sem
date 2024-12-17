namespace Course_3sem;

public interface IVendorService
{
    void AddVendor(Vendor vendor);
    List<Vendor> GetVendors();
    void AddFilmToVendor(Vendor vendor, Film film);
}