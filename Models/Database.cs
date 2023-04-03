namespace TP2_Skyrim.Models
{
    public class Database
    {
        public List<Parent> Parents { get; set; }

        public List<Enfant> Enfants { get; set; }

        public Database()
        {
            Enfants = new List<Enfant>();
            Parents = new List<Parent>();

            Parents.Add(new Parent()
            {
                ParentId = 1,
                Nom = "Le Mage",
                ImageURL = "./images/mage.jpg",
                Description = "Le mage est la classe la plus flexible, elle contient plusieurs habiletés utile pour plusieurs utilisations. " +
                "Le mage n'a pas besoin d'autres classes pour l'aider à réussir, mais il est difficile à améliorer. " +
                "Il possède aussi l'habileté d'enchantement, qui le rend essentiel à n'importe quelle classe."+
                "\n"+ "\n"+ "Il ne se spécialise dans rien, mais est très utile seul.",
                CombatSkills = 3,
                UtilitySkills = 2,
                UpgradeSkills = 1
            });

            Parents.Add(new Parent()
            {
                ParentId = 2,
                Nom = "Le Guerrier",
                ImageURL = "~/images/fighter.jpg",
                Description = "Le Guerrier excèle dans tout ce qui concèrne le combat et la défense. " +
                "Il contient toutes les compétences de combat qui ne consistent pas de la magie. " +
                "De plus, il comprend l'habileté du forgeron, ce qui est utile pour toute classe."+
                "\n" + "\n" + "Il se spécialise dans les compétences de combat, notamment le combat au corp à corp et les armes lourdes.",
                CombatSkills = 4,
                UtilitySkills = 1,
                UpgradeSkills = 1
            });

            Parents.Add(new Parent()
            {
                ParentId = 3,
                Nom = "Le Voleur",
                ImageURL = "images/thief.jpg",
                Description = "La classe du voleur possède plusieurs habiletés qui lui permet de mieux se faufiler, " +
                "éviter les enemies ainsi que de comettre des actes criminels. " +
                "Tout en ayant l'aptitude d'éviter ses répercussions."+
                 "\n" + "\n" + "Il se spécialise dans les compétences hors du combat, notamment la création de potions ainsi que le vol.",
                CombatSkills = 1,
                UtilitySkills = 4,
                UpgradeSkills = 1
            });





            //CHATGPT UTILISÉ POUR LES DESCRIPTIONS




            Enfants.Add(new Enfant()
            {
                EnfantId = 1,
                ParentId = 1,
                Parent = Parents[0],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/e/e6/SkillIllusion.png",
                Nom = "Illusion",
                Description = "Lorem Ipsum",
                NbrCompetences = 13,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 5,
                Difficulté=7
            }) ;

            Enfants.Add(new Enfant()
            {
                EnfantId = 2,
                ParentId = 1,
                Parent = Parents[0],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/2/2c/SkillConjuration.png/",
                Nom = "Conjuration",
                Description = "Lorem Ipsum",
                NbrCompetences = 16,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 4,
                Difficulté = 9
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 3,
                ParentId = 1,
                Parent = Parents[0],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/f/f4/SkillDestruction.png",
                Nom = "Destruction",
                Description = "Lorem Ipsum",
                NbrCompetences = 17,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 7,
                Difficulté = 6
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 4,
                ParentId = 1,
                Parent = Parents[0],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/7/76/SkillRestoration.png/",
                Nom = "Restoration",
                Description = "Lorem Ipsum",
                NbrCompetences = 13,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 6,
                Difficulté = 6
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 5,
                ParentId = 1,
                Parent = Parents[0],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/b/ba/SkillAlteration.png",
                Nom = "Altération",
                Description = "Lorem Ipsum",
                NbrCompetences = 14,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 4,
                Difficulté = 7
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 6,
                ParentId = 1,
                Parent = Parents[0],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/c/ce/SkillEnchanting.png/",
                Nom = "Enchantement",
                Description = "Lorem Ipsum",
                NbrCompetences = 13,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Amélioration",
                NiveauDeRecommendation = 10,
                Difficulté = 8
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 7,
                ParentId = 2,
                Parent = Parents[1],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/2/2b/SkillSmithing.png/",
                Nom = "Forgeage",
                Description = "Lorem Ipsum",
                NbrCompetences = 10,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Amélioration",
                NiveauDeRecommendation = 10,
                Difficulté = 8
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 8,
                ParentId = 2,
                Parent = Parents[1],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/b/b7/SkillHeavyarmor.png",
                Nom = "Armure Lourde",
                Description = "Lorem Ipsum",
                NbrCompetences = 12,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 7,
                Difficulté = 3
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 9,
                ParentId = 2,
                Parent = Parents[1],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/c/c7/SkillBlock.png/",
                Nom = "Bloque",
                Description = "Lorem Ipsum",
                NbrCompetences = 13,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 4,
                Difficulté = 4
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 10,
                ParentId = 2,
                Parent = Parents[1],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/f/fa/SkillTwohanded.png/",
                Nom = "Deux Main",
                Description = "Lorem Ipsum",
                NbrCompetences = 19,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 7,
                Difficulté = 3
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 11,
                ParentId = 2,
                Parent = Parents[1],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/b/b5/SkillOnehanded.png/",
                Nom = "Une Main",
                Description = "Lorem Ipsum",
                NbrCompetences = 21,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 7,
                Difficulté = 3
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 12,
                ParentId = 2,
                Parent = Parents[1],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/f/fa/SkillArchery.png/",
                Nom = "Archerie",
                Description = "Lorem Ipsum",
                NbrCompetences = 16,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 8,
                Difficulté = 4
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 13,
                ParentId = 3,
                Parent = Parents[2],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/2/2d/SkillLightarmor.png/",
                Nom = "Armure Légère",
                Description = "Lorem Ipsum",
                NbrCompetences = 10,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 10,
                Difficulté = 8
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 14,
                ParentId = 3,
                Parent = Parents[2],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/8/82/SkillSneak.png/",
                Nom = "Furtivité",
                Description = "Lorem Ipsum",
                NbrCompetences = 13,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 9,
                Difficulté = 6
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 15,
                ParentId = 3,
                Parent = Parents[2],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/3/3d/SkillLockpicking.png/",
                Nom = "Crochetage",
                Description = "Lorem Ipsum",
                NbrCompetences = 11,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 3,
                Difficulté = 2
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 16,
                ParentId = 3,
                Parent = Parents[2],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/a/a8/SkillPickpocket.png",
                Nom = "Vol",
                Description = "",
                NbrCompetences = 12,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 6,
                Difficulté = 10
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 17,
                ParentId = 3,
                Parent = Parents[2],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/1/18/SkillSpeech.png",
                Nom = "Éloquence",
                Description = "L'Éloquence est une compétence qui permet aux joueurs de persuader les personnages non-joueurs (PNJ) de faire ce qu'ils veulent ou de les convaincre de leur donner des informations ou des objets. " +
                "Cette compétence est particulièrement utile pour les joueurs qui souhaitent éviter les combats ou pour ceux qui préfèrent résoudre les problèmes de manière pacifique."+
                "\n" + "\n" +
                "Lorsque les joueurs interagissent avec des PNJ, ils ont la possibilité de choisir différentes options de dialogue, " +
                "qui peuvent être influencées par leur niveau de compétence en Éloquence. Les joueurs peuvent utiliser des compétences comme l'intimidation, " +
                "la persuasion ou la séduction pour influencer les PNJ et obtenir ce qu'ils veulent."+
                "\n" + "\n" +
                "En fonction des situations, les PNJ peuvent être plus ou moins réceptifs aux tentatives de persuasion du joueur. Par exemple, " +
                "un PNJ peut être plus enclin à aider le joueur s'il a une bonne réputation ou s'il a accompli des quêtes pour sa faction."+
                "En plus de persuader les PNJ, la compétence d'Éloquence peut également être utilisée pour acheter et vendre des objets à un prix plus avantageux auprès des marchands. " +
                "Les joueurs peuvent investir dans cette compétence en dépensant des points de compétence pour débloquer des améliorations qui augmentent leur pouvoir de persuasion, " +
                "comme la capacité à vendre des objets à des prix plus élevés ou à persuader les PNJ de faire des choses qu'ils ne feraient pas normalement."+
                "\n" + "\n" +
                "En résumé, la compétence d'Éloquence est un outil essentiel pour les joueurs qui cherchent à résoudre les problèmes de manière pacifique " +
                "ou à obtenir des avantages lors des transactions commerciales. " +
                "Elle leur permet de persuader les PNJ de faire ce qu'ils veulent en utilisant des compétences comme l'intimidation, la persuasion ou la séduction.",
                NbrCompetences = 13,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 7,
                Difficulté = 4
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 18,
                ParentId = 3,
                Parent = Parents[2],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/b/b9/SkillAlchemy.png",
                Nom = "Alchimie",
                Description = "La compétence d'Alchimie dans Skyrim est une compétence très pratique qui permet aux joueurs de créer des potions et des poisons en combinant différents ingrédients. " +
                "Les ingrédients peuvent être trouvés dans tout le monde de Skyrim, des plantes et des champignons poussant dans les forêts aux insectes et aux morceaux d'animaux que l'on trouve sur les routes."+
                "\n"+ "\n"+
                "Pour créer une potion, le joueur doit trouver un laboratoire d'alchimie et y placer les ingrédients qu'il souhaite combiner. " +
                "Chaque ingrédient a ses propres effets et valeurs, et en combinant différents ingrédients, le joueur peut créer des potions avec des effets uniques et puissants."+
                "\n" + "\n" +
                "La qualité des potions créées dépend de la compétence du joueur en alchimie, " +
                "qui augmente à mesure que le joueur crée des potions et découvre de nouveaux ingrédients. " +
                "Plus la compétence d'Alchimie du joueur est élevée, plus il sera capable de créer des potions puissantes et de découvrir les effets cachés des ingrédients. " +
                "Les joueurs peuvent également acheter des recettes de potions auprès des marchands ou les trouver en explorant le monde de Skyrim."+
                "\n" + "\n" +
                "Les potions créées peuvent être utilisées pour une variété de tâches, comme améliorer les statistiques du personnage, " +
                "soigner des maladies ou des blessures, ou fournir d'autres avantages temporaires. Les poisons, quant à eux, " +
                "peuvent être utilisés pour empoisonner des armes ou des pièges et infliger des dégâts à des ennemis."+
                "\n" + "\n" +
                "En plus de créer des potions et des poisons, la compétence d'Alchimie permet également aux joueurs de récolter plus d'ingrédients à partir des plantes et des champignons, " +
                "et de vendre des potions à un prix plus élevé aux marchands. " +
                "Cela en fait une compétence très utile pour les joueurs qui cherchent à gagner de l'argent et à améliorer leur personnage.",
                NbrCompetences = 15,
                UtilGen = "Utile pour tous",
                TypeAbilite = "Amélioration",
                NiveauDeRecommendation = 8,
                Difficulté = 4
            });



        }


    }
}
