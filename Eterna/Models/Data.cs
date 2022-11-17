using System;
using System.Collections.Generic;

namespace Eterna.Models
{
	public static class Data
	{
		public static List<Service> Services = new List<Service>
		{
			new Service{Id=1,Title="Lorem Ipsum",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi",Icon="bx bxl-dribbble"},
            new Service{Id=2,Title="Sed ut perspiciatis",Desc="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore",Icon="bx bx-file"},
            new Service{Id=3,Title="Magni Dolores",Desc="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia",Icon="bx bx-tachometer"},
            new Service{Id=4,Title="Divera don",Desc="Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur",Icon="bx bx-world"},
            new Service{Id=5,Title="Nemo Enim",Desc="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis",Icon="bx bx-slideshow"},
            new Service{Id=6,Title="Dele cardo",Desc="Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur",Icon="bx bx-arch"},
        }; 
        public static List<Feature> Features = new List<Feature>
        {
            new Feature{Id=1,Title="Lorem Ipsum",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident",Icon="<i class=\"bi bi-card-checklist\"></i>"},
            new Feature{Id=2,Title="Dolor Sitema",Desc="Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata",Icon="<i class=\"bi bi-bar-chart\"></i>"},
            new Feature{Id=3,Title="Sed ut perspiciatis",Desc="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur",Icon="<i class=\"bi bi-binoculars\"></i>"},
        };
        public static List<Slide> Slides = new List<Slide>
        {
            new Slide{Id=1,Title1="Welcome to",Title2="Eterna",Desc="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",Image="slide-1.jpg"},
            new Slide{Id=2,Title1="Lorem",Title2="Ipsum Dolor",Desc="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",Image="slide-2.jpg"},
            new Slide{Id=3,Title1="Sequi ea",Title2="Dime Lara",Desc="Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",Image="slide-3.jpg"},
        };
        public static List<Team> Teams = new List<Team>
        {
            new Team{Id=1,Image="team-1.jpg",FullName="Walter White",Position="Chief Executive Officer",Info="Magni qui quod omnis unde et eos fuga et exercitationem. Odio veritatis perspiciatis quaerat qui aut aut aut"},
            new Team{Id=2,Image="team-2.jpg",FullName="Sarah Jhinson",Position="Product Manager",Info="Repellat fugiat adipisci nemo illum nesciunt voluptas repellendus. In architecto rerum rerum temporibus" },
            new Team{Id=3,Image="team-3.jpg",FullName="William Anderson",Position="CTO",Info="Voluptas necessitatibus occaecati quia. Earum totam consequuntur qui porro et laborum toro des clara" }
        };

    }
}

