using Packt.Shared;

int thiscannotbenull = 4;
//thiscannotbenull = null;
WriteLine(thiscannotbenull);

int? thiscouldbenull = null;

WriteLine(thiscouldbenull);
WriteLine(thiscouldbenull.GetValueOrDefault());

thiscouldbenull = 7;

WriteLine(thiscouldbenull);
WriteLine(thiscouldbenull.GetValueOrDefault());

Nullable<int> thiscouldalsobenull = null;
thiscouldalsobenull = 9;
WriteLine(thiscouldalsobenull);

Address address = new(city: "London")
{
    Building = null,
    Street = null!,
    Region = "UK"
};

WriteLine(address.Building?.Length);

if (address.Street is not null)
{
    WriteLine(address.Street.Length);
}
