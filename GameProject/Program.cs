// See https://aka.ms/new-console-template for more information

using GameProject;

GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
gamerManager.Add(new Gamer { Id = 1, BirthYear = 1999, FirstName = "Rümeysa", LastName = "AVCI", IdentityNumber = 12345 });

Campaign campaign1 = new Campaign();
campaign1.Id = 1;
campaign1.Description = "Yeni Kampanyamız";

CampaignManager campaignManager = new CampaignManager();
campaignManager.Add(campaign1);

Order order1 = new Order();
order1.Id = 1;
order1.Name = "İlk satışınız";

OrderManager orderManager = new OrderManager();
orderManager.Add(order1);
