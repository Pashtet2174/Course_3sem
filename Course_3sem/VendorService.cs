namespace Course_3sem;

public class VendorService : IVendorService

{
    private readonly List<Vendor> _vendors = new();
    
    public void AddVendor(Vendor vendor)
    {
        _vendors.Add(vendor);
    }

    public List<Vendor> GetVendors()
    {
        return _vendors;
    }

    public void AddFilmToVendor(Vendor vendor, Film film)
    {
        vendor.AddFilm(film);
    }
}