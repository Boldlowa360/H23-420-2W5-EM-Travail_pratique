﻿namespace TP2.Models
{
    public class Database
    {
        public List<Parent> Parents { get; set; }
        public List<Enfant> Enfants { get; set; }

        public Database()
        {
            Parents = new List<Parent>();
            Enfants = new List<Enfant>();

            //liste parents
            Parents.Add(new Parent() { Id = 1, Nom = "Dps", Logo = "/image/Dps.png", nbreHéros = 17, pointFort = "Créer des engagements pour obtenir des kills et permettre à son équipe d'avancer", description = "Les spécialistes des dégats traquent, attaquent et éliminent l'ennemi avec toutes sortes d'outils, de capacités et de styles de jeu. Redoutables mais fragiles, ces personnages ont besoin de renforts pour survivre." });
            Parents.Add(new Parent() { Id = 2, Nom = "Soigneur", Logo = "/image/Healer.png", nbreHéros = 8, pointFort = "Garde son équipe en vie grâce a du soins ou donne un petit boost à ses alliers", description = "Les personnages de soutien assistent leurs alliés en leur procurant des soins et des boucliers, en augmentant leurs dégats et en neutralisant les menaces. Votre rôle de soutien vous rend indispensable à la survie de vortre équipe." });
            Parents.Add(new Parent() { Id = 3, Nom = "Tank", Logo = "/image/Tank.png", nbreHéros = 11, pointFort = "Quantité de vie plus importante que les autres rôles", description = "Les tanks sont là pour encaisser les dégats et s'attaquer à des positions stratégiques, qu'il s'agisse d'ennemis groupés ou de points d'étranglement. Si vous êtes un tank, c'est à vous de mener la charge." });

            //Listes Enfants
            //Tank
            Enfants.Add(new Enfant() { id = 1, nom = "D.Va", IdParent = 3, hp = 500, difficulté = 2, Role = "Tank", age = 19, nationnalité = "Coréenne", image = "/image/Icon-D.Va.png", description = "Avec des réflexes agiles et une réflexion rapide, D.Va est une ancienne joueuse professionnelle qui utilise maintenant ses compétences pour piloter un robot à la pointe de la technologie pour défendre sa patrie . Elle est une personne très compétitive, et couplée à ses compétences de pro-gamer, cela fait d'elle un pilote mech extrêmement efficace. Ne reculant jamais, D.Va joue toujours pour gagner. Alors qu'elle projette une attitude insouciante et irrévérencieuse, D.Va est accablée par le coût émotionnel de la défense de sa patrie et la façade que les médias sud-coréens projettent sur elle." });
            Enfants.Add(new Enfant() { id = 2, nom = "Reinhardt", IdParent = 3, hp = 450, difficulté = 1, Role = "Tank", age = 61, nationnalité = "Allemand", image = "/image/Icon-Reinhardt.png", description = "Soldat allemand hautement décoré, Reinhardt appartenait aux croisés, des combattants aguerris dont les énormes armures leur conféraient des capacités sans pareilles. Si son mentor, Balderich von Adler, devait initialement rejoindre Overwatch, c’est Reinhardt qui fut recruté après que celui-ci perdit la vie lors de la bataille d’Eichenwalde. Il rejoignit ainsi la première équipe d’intervention de l’organisation, celle-là même qui finit par mettre un terme à la crise des Omniums. Après la résolution du conflit, Overwatch grandit pour devenir une institution mondiale chargée de maintenir la paix dans un monde déchiré par les guerres. La déontologie inflexible et la personnalité hors du commun de Reinhardt lui valurent l’admiration de ses pairs comme de ses supérieurs.Jamais réticent à parler franchement,il était le partisan le plus démonstratif d’Overwatch,mais au besoin, il savait aussi en être le critique le plus impitoyable,ne manquant jamais de rappeler à tous que l’organisation était censée rester au service du bien commun.À la veille de ses soixante ans,Reinhardt fut contraint de quitter le service actif.Déprimé,il craignait de perdre sa raison d’être et que ses jours de gloire ne soient derrière lui.Alors que le climat s’assombrissait et qu’Overwatch était mis en cause dans des affaires de corruption et de sédition, Reinhardt ne put qu’assister à l’effondrement et à la disgrâce de la cause qu’il avait dédié sa vie à défendre." });
            Enfants.Add(new Enfant() { id = 3, nom = "Orisa", IdParent = 3, hp = 400, difficulté = 1, Role = "Tank", age = 1, nationnalité = "Numbanian", image = "/image/Icon-Orisa.png", description = "Orisa est un omnique nouvellement créé avec à la fois un cœur et une personnalité. Poussée à devenir une héroïne par son créateur, Efi Oladele , Orisa s'efforce de réparer les torts et d'agir comme l'héroïne dont le monde a besoin. [5] Alors que son inexpérience relative peut faire d'elle un handicap occasionnel, l'optimisme d'Efi et sa volonté d'apporter des modifications à l'intelligence artificielle adaptative d'Orisa ont toujours été en mesure de redresser la situation. Alors qu'Orisa a beaucoup à apprendre sur le monde et ses fonctionnalités, Orisa se tient prête à protéger à la fois Efi et Numbani avec son sens croissant de l'honneur et du devoir." }); ;
            Enfants.Add(new Enfant() { id = 4, nom = "Chopper", IdParent = 3, hp = 550, difficulté = 1, Role = "Tank", age = 48, nationnalité = "Australien", image = "/image/Icon-Roadhog.png", description = "7'3\" (221 cm) de hauteur et 550 livres (250 kg), Roadhog est un tueur impitoyable avec une réputation bien méritée de cruauté et de destruction gratuite. Il reste silencieux la plupart du temps. Il porte un masque avec des inhalateurs \" hogdrogen \", qui contiennent un mélange chimique sous pression qui aide à contrer les effets de l'exposition aux radiations.\r\n\r\nAprès la crise omnique, les représentants du gouvernement ont offert l'omnium australien et la région environnante aux omniques qui avaient presque détruit leur pays, dans l'espoir d'établir un accord de paix à long terme. Cet arrangement a définitivement déplacé Mako Rutledge et un grand nombre d'habitants de l'Outback, une collection dispersée de survivalistes, d'agriculteurs solaires et de personnes qui voulaient juste être laissées seules.\r\n\r\nFurieux de la perte de leurs maisons, Mako et d'autres se sont tournés vers une violente rébellion. Ils ont formé le Front de libération australien et ont attaqué l'omnium et sa population de robots pour reprendre les terres qui avaient été volées. Les événements ont continué à s'intensifier jusqu'à ce que les rebelles sabotent le noyau de fusion de l'omnium, entraînant une explosion qui a détruit l'installation, irradié la région et jonché l'Outback de métal tordu et d'épaves à des kilomètres à la ronde." });
            Enfants.Add(new Enfant() { id = 5, nom = "Winston", IdParent = 3, hp = 400, difficulté = 2, Role = "Tank", age = 29, nationnalité = "inconnue", image = "/image/Icon-Winston.png", description = "Winston est un gorille génétiquement modifié : son intelligence hors du commun fait de lui un scientifique brillant dont la douceur n’a d’égale que sa puissance sur le champ de bataille. Après s’être échappé de la colonie lunaire Horizon, il a trouvé refuge au sein d’Overwatch et est devenu le héros qu’il avait toujours rêvé d’être… jusqu’à la dissolution de l’organisation. À présent, alors que le monde subit les assauts du Secteur zéro, Winston rappelle ses camarades d’autrefois. Une nouvelle Overwatch est née." });
            //DPS
            Enfants.Add(new Enfant() { id = 6, nom = "Hanzo", IdParent = 1, hp = 200, difficulté = 3, Role = "Dégat", age = 38, nationnalité = "Japonais", image = "/image/Icon-Hanzo.png", description = "Maîtrisant ses talents d'archer et d'assassin, Hanzo Shimada s'efforce de faire ses preuves en tant que guerrier sans égal. Il a une vision cynique de la nature du monde, et croit que la compassion n'a pas sa place dans la bataille. \r\n\r\nEn plus de ses compétences avec l'arc, Hanzo est également habile avec l'épée, mais a juré d'utiliser une telle arme. Il considère les arbalètes comme des \"jouets pour enfants\"  et refuse d'utiliser des armes à feu, car \"elles rendent le meurtre trop simple\".\r\n\r\n La famille Shimada a été créée il y a des siècles, un clan d'assassins dont le pouvoir a grandi au fil des ans, leur permettant de construire un vaste empire criminel à partir d' Hanamura qui a profité du commerce lucratif d'armes et de substances illégales. En tant que fils aîné de Sojiro Shimada , le chef de famille, Hanzo était tenu par le devoir de succéder à son père et de diriger l'empire Shimada,  traitant des attentes que son jeune frère, Genji , n'avait pas. Alors qu'il éclipsait Genji dans son statut, Hanzo préférait avoir son frère à ses côtés." });
            Enfants.Add(new Enfant() { id = 7, nom = "Ashe", IdParent = 1, hp = 200, difficulté = 2, Role = "Dégat", age = 39, nationnalité = "Américaine", image = "/image/Icon-Ashe.png", description = "Ashe est le chef ambitieux et calculateur du Deadlock Gang et une figure respectée de la pègre.\r\n\r\nAshe a un état d'esprit organisé. Cela affecte ses idées sur la façon dont son organisation devrait être gérée, sur la façon dont les relations devraient fonctionner. Sa relation avec Cole Cassidy est \"bien plus compliquée\" qu'une simple étiquette, bien qu'elle puisse être décrite comme une relation de type \"amour-haine\". \r\n\r\nEn tant que fille de mondains, Ashe se sent aussi à l'aise aux bals de charité qu'à moto. Elle est un bon tireur avec un fusil, croyant que la précision est la clé et que tout ce dont on devrait avoir besoin est un seul coup." });
            Enfants.Add(new Enfant() { id = 8, nom = "Sojourn", IdParent = 1, hp = 200, difficulté = 2, Role = "Dégat", age = 52, nationnalité = "Canadienne", image = "/image/Icon-Sojourn.png", description = "Sojourn était membre d' Overwatch , rejoignant à un moment donné l'âge d'or de l'organisation et restant avec eux jusqu'à leurs dernières années. De soldat à capitaine Overwatch en passant par vétéran, Sojourn a consacré sa vie à aider ceux qui seraient victimes des maux du monde. Jamais du genre à se battre pour la gloire personnelle, Sojourn s'est battue parce qu'elle était nécessaire, et si ce besoin se présentait, Sojourn y répondrait.\r\n\r\nDédié à l'état de droit, Sojourn est soucieux du détail. C'est une brillante tacticienne, une grande dirigeante, et un type d'individu « mesurer deux fois, couper une fois ». Elle est connue pour sa discipline et est douée pour jouer aux cartes. Elle est plus basketteuse que hockeyeuse. " });
            Enfants.Add(new Enfant() { id = 9, nom = "Torbjörn", IdParent = 1, hp = 250, difficulté = 2, Role = "Dégat", age = 57, nationnalité = "Suédois", image = "/image/Icon-TORBJÖRN.png", description = "Torbjörn Lindholm (appelé \"Torby\" par ses amis) est l'un des plus grands armuriers et ingénieurs du monde. Il avait une mauvaise opinion des omniques , les croyant incapables d'empathie, agissant plutôt uniquement sur la logique, et n'était pas d'accord avec le fait de leur donner les mêmes droits que les humains. Son 'adoption' de Bastion , cependant, l'a amené à s'interroger sur son antipathie pour les robots et les omnics." });
            Enfants.Add(new Enfant() { id = 10, nom = "Bastion", IdParent = 1, hp = 300, difficulté = 1, Role = "Dégat", age = 30, nationnalité = "inconnue", image = "/image/Icon-Bastion.png", description = "Abandonnée et en veille depuis la fin de la terrible crise des Omniums, cette unité Bastion pour le moins étrange s’est réveillée dans monde nouveau. Autrefois hostile, elle était désormais douée de curiosité et fascinée par la nature. En compagnie de Ganymède, un oiseau qui ne le quitte plus, Bastion a finalement été recueilli par Torbjörn Lindholm, et travaille à présent à ses côtés à aider l’humanité au lieu de la combattre." });
            //Healer
            Enfants.Add(new Enfant() { id = 11, nom = "Ange", IdParent = 2, hp = 200, difficulté = 1, Role = "Soigneur", age = 37, nationnalité = "Suisse", image = "/image/Icon-Mercy.png", description = "Ange gardien pour ceux qui lui sont confiés, le Dr Angela Ziegler est une guérisseuse hors pair, une brillante scientifique et une ardente défenseure de la paix. Elle est l'un des médecins les plus doués au monde en matière de technologie médicale et a appliqué cette technologie à son propre corps. Elle aime le chocolat suisse et aime le thé, qu'elle prend parfois avec une pincée de cognac après une épreuve potentiellement mortelle. Cependant, elle n'est pas douée pour faire du café - Genji était le seul membre d'Overwatch qui pouvait supporter d'en boire." });
            Enfants.Add(new Enfant() { id = 12, nom = "Ana", IdParent = 2, hp = 200, difficulté = 3, Role = "Soigneur", age = 60, nationnalité = "Égyptienne", image = "/image/Icon-Ana.png", description = "L'une des membres fondatrices d'Overwatch, Ana utilise ses compétences et son expertise pour défendre sa maison et les personnes dont elle s'occupe. Issue d'une longue lignée de soldats décorés, Ana a inspiré confiance et loyauté à ses collègues et a doté sa fille, Fareeha Amari - Pharah , d'un sens intense du devoir et de l'honneur. Comme sa fille, elle portait un tatouage d'un Oeil d'Horus comme symbole de protection. De même, son indicatif dans l'armée égyptienne pendant la crise omnique était \"Horus\". À ce jour, Ana est considérée comme une héroïne par le peuple égyptien." });
            Enfants.Add(new Enfant() { id = 13, nom = "Kiriko", IdParent = 2, hp = 200, difficulté = 3, Role = "Soigneur", age = 20, nationnalité = "Japonaise", image = "/image/Icon-kiriko.png", description = "Kiriko est effrontée et pleine de vie. Elle a un humour de style ironique et n'a pas peur de taquiner les autres, peu importe à quel point ils peuvent sembler intimidants. Elle dégage une énergie et une intelligence juvéniles; une combinaison qui la rend extrêmement agréable. Elle adore plaisanter avec ses coéquipiers, et tout manque de respect ou culot qui lui est envoyé est simplement redirigé, Comme l' esprit renard qui l'aide, Kiriko est une escroc, mais bien qu'un escroc et légère, Kiriko a une forte boussole morale et croit qu'il faut prendre soin de ceux qui l'entourent. Elle est intelligente et est un leader naturel." });
            Enfants.Add(new Enfant() { id = 14, nom = "Lucio", IdParent = 2, hp = 200, difficulté = 2, Role = "Soigneur", age = 26, nationnalité = "Brésilien", image = "/image/Icon-Lucio.png", description = "Lúcio est une célébrité internationale qui inspire le changement social à travers sa musique et ses actions. Il a une attitude positive et optimiste  et regarde toujours vers l'avenir. Il a du mal à se calmer. \r\n\r\nLúcio porte des patins à lumière dure qui projettent des \"lames\" à lumière dure, lui permettant de traverser n'importe quelle surface." });
            Enfants.Add(new Enfant() { id = 15, nom = "Baptiste", IdParent = 2, hp = 200, difficulté = 3, Role = "Soigneur", age = 36, nationnalité = "haïtien", image = "/image/Icon-Baptiste.png", description = "Jean-Baptiste Augustin faisait partie des trente millions d’orphelins causés par la crise des Omniums. Disposant de peu d’opportunités et de ressources, il s’enrôla dans l’armée. La Coalition caribéenne, une armée insulaire formée en réponse à la crise, devint sa nouvelle famille. Guidé par un profond désir d’aider les gens, Baptiste choisit de suivre la voie de secouriste militaire et servit dans les forces spéciales de la Coalition caribéenne.\r\n\r\nUne fois son service accompli, Baptiste eut du mal à trouver comment mettre ses compétences à profit. Il accepta une des rares opportunités qui s’offraient à lui, rejoindre un groupe de mercenaires de la Griffe, une des nombreuses organisations vouées à tirer profit du chaos post-affrontements." });
            foreach (var p in Parents)
            {
                p.Enfants = new List<Enfant>();
                p.Enfants.AddRange(Enfants.Where(e => e.IdParent == p.Id));
            }

            foreach (var e in Enfants)
            {
                e.Parent = Parents.Where(p => p.Id == e.IdParent).Single();
            }
        }


    }
}