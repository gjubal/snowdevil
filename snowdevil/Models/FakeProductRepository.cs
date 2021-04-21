using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace snowdevil.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product { Name = "Nidecker: Axis", Price = 199.00, Category =  "Snowboards", Description = "Designed with expertise of Bertrand Denervaud, to perform equally while freestyling and freeriding. The Axis is a higher quality board to learn on at an affordable price. With an all cap all woodcore construction; this board is a true value in the Nidecker line. Its wide design will provide ultimate comfort for bigger feet."},
            new Product { Name = "Adidas: Titan", Price = 399.00, Category = "Snowboards", Description =  "The most technically advanced freeride snowboard built by Never Summer. The Titan will provide a smoother ride with a much quicker response than any other freeride snowboard you have ridden. For those who want to experience the ultimate freeride snowboards, Titan provides exclusive laminates, base material, damping system and shape. Never Summer will only produce 650 Titans this season and each of them is individually numbered."},
            new Product { Name = "Never Summer: T5", Price = 199.00, Category = "Snowboards", Description = "The T5 © has the ideal amount of sidecut, flex, and damping for big mountain riding. This board delivers an incredibly stable and responsive ride for high speed cruising or dropping into the most remote backcountry. There is no other big mountain freeride board that can dominate all terrain like this one." },
            new Product { Name = "Adidas: K2", Price = 354.00, Category = "Snowboards", Description =  "The most technically advanced freeride snowboard built by Never Summer. The Titan will provide a smoother ride with a much quicker response than any other freeride snowboard you have ridden. For those who want to experience the ultimate freeride snowboards, Titan provides exclusive laminates, base material, damping system and shape. Never Summer will only produce 650 Titans this season and each of them is individually numbered."},
            new Product { Name = "Arbor: A-Frame", Price = 255.00, Category = "Snowboards", Description =  "This big-mountain freeride-specific board is the answer for those riders who are looking for on-edge performance. The A-Frame’s was designed to lock into and hold a deeply carved line and provide tighter edge control in the steeps. It creates a solid landing platform and adds power edge-to-edge with its beefed up tail. And if that’s not good enough for you, a structural real-wood topsheet, made with Hoa, Maple, and Walnut should seal the deal."},
            new Product { Name = "Adidas: Elevation Climacool", Price = 120.00, Category = "Goggles", Description =  "Features: decentered anti-fog Vision Advantage PC lenses TRI.FIT; temple double-snap nose bridge; quick change lens system; traction grip ClimaCool foam pad ventilation system; optional performance insert; head strap; hardcase competition. XL includes spare orange lens."},
            new Product { Name = "Adidas: Evil Eye Explore", Price = 99.00, Category = "Goggles", Description =  "This innovative, multi-feature frame provides enhanced vision, individualized fit, and eye protection at high altitudes. Features the new Space Lens developed for NASA and interpreted by Adidas eyewear to protect against extreme light. Performance engineered SPX frame design keeps out wind yet maintains ventilation access. Comes with temples and a head strap. Other features include decentered Vision Advantage PCLens, double-snap nose bridge, ventilation system and sweat blocker. Available in two sizes, medium and large."}
        };
    }
}
