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

            //Ajout des parents
            Parents.Add(new Parent()
            {
                
                ParentId = 1,
                Nom = "Le Mage",
                ImageURL = "/images/mage.jpg",
                Description = "Le mage est la classe la plus flexible, elle contient plusieurs habiletés utile pour plusieurs utilisations. " +
                "Le mage n'a pas besoin d'autres classes pour l'aider à réussir, mais il est difficile à améliorer. " +
                "Il possède aussi l'habileté d'enchantement, qui le rend essentiel à n'importe quelle classe." +
                "\n" + "\n" + "Il ne se spécialise dans rien, mais est très utile seul.",
                
                UtilitySkills = 2,
                UpgradeSkills = 1
            });

            Parents.Add(new Parent()
            {
                ParentId = 2,
                Nom = "Le Guerrier",
                ImageURL = "/images/fighter.jpg",
                Description = "Le Guerrier excèle dans tout ce qui concèrne le combat et la défense. " +
                "Il contient toutes les compétences de combat qui ne consistent pas de la magie. " +
                "De plus, il comprend l'habileté du forgeron, ce qui est utile pour toute classe." +
                "\n" + "\n" + "Il se spécialise dans les compétences de combat, notamment le combat au corp à corp et les armes lourdes.",
                CombatSkills = 4,
                UtilitySkills = 1,
                UpgradeSkills = 1
            });

            Parents.Add(new Parent()
            {
                ParentId = 3,
                Nom = "Le Voleur",
                ImageURL = "/images/thief.jpg",
                Description = "La classe du voleur possède plusieurs habiletés qui lui permet de mieux se faufiler, " +
                "éviter les enemies ainsi que de comettre des actes criminels. " +
                "Tout en ayant l'aptitude d'éviter ses répercussions." +
                 "\n" + "\n" + "Il se spécialise dans les compétences hors du combat, notamment la création de potions ainsi que le vol.",
                CombatSkills = 1,
                UtilitySkills = 4,
                UpgradeSkills = 1
            });





            //CHATGPT UTILISÉ POUR LES DESCRIPTIONS (demander de le faire dans une variable string de c#)



            //ajout des enfants
            Enfants.Add(new Enfant()
            {
                EnfantId = 1,
                ParentId = 1,
                Parent = Parents[0],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/e/e6/SkillIllusion.png",
                Nom = "Illusion",
                Description = "L'habileté d'Illusion permet au joueur de manipuler les esprits de ses ennemis en altérant leur perception de la réalité. Cette compétence permet de créer des illusions visuelles, sonores et mentales pour tromper les sens de l'ennemi. Elle permet notamment de se camoufler pour passer inaperçu, de calmer les ennemis pour éviter les combats, de les faire fuir en leur faisant croire qu'ils sont attaqués par des alliés ou des créatures effrayantes, de les charmer pour qu'ils agissent en faveur du joueur, de les rallier à sa cause pour qu'ils le suivent ou encore de les inciter à se combattre entre eux pour réduire leurs forces. L'illusion est une compétence très utile pour les joueurs souhaitant adopter une approche plus furtive, diplomatique ou manipulatrice du jeu.",
                NbrCompetences = 13,
                UtilGen = "Utile pour un voleur ou pour éviter le combat.",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 5,
                Difficulté = 7,
                Image1Logo = "https://images.uesp.net/2/22/SR-perktree-Illusion.jpg",
                Image2SS = "/images/illusion ss.png",
                Image3Art = "https://images.uesp.net/8/86/LG-cardart-Cloudrest_Illusionist.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 2,
                ParentId = 1,
                Parent = Parents[0],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/2/2c/SkillConjuration.png/",
                Nom = "Conjuration",
                Description = "L'habileté de Conjuration de Skyrim permet au joueur d'invoquer des créatures et des objets magiques pour l'aider dans les combats. Les sorts de Conjuration peuvent être utilisés pour invoquer des créatures telles que des atronachs, des squelettes ou des dragons. Ils peuvent également être utilisés pour invoquer des armes ou des armures magiques pour le joueur ou ses alliés.\n\nPour améliorer cette compétence, le joueur doit utiliser des sorts de Conjuration. Plus les sorts sont puissants, plus ils rapportent d'expérience. Le joueur peut également utiliser des sorts ou des potions pour augmenter sa compétence en Conjuration.\n\nL'habileté de Conjuration est très utile pour les joueurs qui cherchent à avoir un avantage numérique dans les combats. Les créatures invoquées peuvent servir de distraction pour les ennemis, tandis que les armes ou les armures magiques peuvent renforcer les capacités du joueur ou de ses alliés. Elle est également utile pour les joueurs qui préfèrent une approche plus tactique dans les combats.\n\nEn plus de permettre au joueur d'invoquer des créatures et des objets magiques, l'habileté de Conjuration offre également des bonus passifs en fonction de son niveau. Ces bonus peuvent inclure une réduction du coût des sorts de Conjuration, une augmentation de leur efficacité ou encore une réduction du temps de recharge des sorts d'invocation.\n\nEn résumé, l'habileté de Conjuration est une compétence essentielle pour les joueurs qui cherchent à avoir un avantage numérique dans les combats ou une approche plus tactique, ainsi que pour les joueurs qui cherchent à invoquer des armes ou des armures magiques pour renforcer leurs capacités.",
                NbrCompetences = 16,
                UtilGen = "Utile pour avoir de l'aide en combat.",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 4,
                Difficulté = 9,
                Image1Logo = "https://images.uesp.net/3/36/SR-perktree-Conjuration.jpg",
                Image2SS = "https://images.uesp.net/thumb/5/5a/SR-creature-Flame_Atronach.jpg/600px-SR-creature-Flame_Atronach.jpg",
                Image3Art = "https://images.uesp.net/7/78/LG-cardart-Conjuration_Scholar.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 3,
                ParentId = 1,
                Parent = Parents[0],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/f/f4/SkillDestruction.png",
                Nom = "Destruction",
                Description = "L'habileté de Destruction de Skyrim permet au joueur d'utiliser la magie pour infliger des dégâts élémentaires tels que le feu, la foudre et le gel aux ennemis. Les sorts de Destruction peuvent être lancés à distance ou au corps-à-corps et peuvent être utilisés pour vaincre les ennemis les plus puissants de Skyrim.\n\nPour améliorer cette compétence, le joueur doit utiliser des sorts de Destruction. Plus les sorts sont puissants, plus ils rapportent d'expérience. Le joueur peut également utiliser des sorts ou des potions pour augmenter sa compétence en Destruction.\n\nL'habileté de Destruction est très utile pour les joueurs qui cherchent à infliger des dégâts à distance et qui préfèrent une approche offensive dans les combats. Elle est également utile pour les joueurs qui cherchent à vaincre des ennemis résistants aux armes physiques.\n\nEn plus de permettre au joueur de lancer des sorts de Destruction, l'habileté de Destruction offre également des bonus passifs en fonction de son niveau. Ces bonus peuvent inclure une réduction du coût des sorts de Destruction, une augmentation de leur efficacité ou encore une augmentation des dégâts infligés aux ennemis.\n\nEn résumé, l'habileté de Destruction est une compétence essentielle pour les joueurs qui cherchent à infliger des dégâts à distance et qui préfèrent une approche offensive dans les combats, ainsi que pour les joueurs qui cherchent à vaincre des ennemis résistants aux armes physiques.",
                NbrCompetences = 17,
                UtilGen = "Utile pour le combat magique.",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 7,
                Difficulté = 6,
                Image1Logo = "https://images.uesp.net/3/38/SR-perktree-Destruction.jpg",
                Image2SS = "/images/destruction ss.png",
                Image3Art = "https://images.uesp.net/4/4b/LG-cardart-Cruel_Firebloom.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 4,
                ParentId = 1,
                Parent = Parents[0],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/7/76/SkillRestoration.png/",
                Nom = "Restoration",
                Description = "L'habileté de Restoration de Skyrim permet au joueur d'utiliser la magie pour restaurer la santé, la vigueur et les attributs du joueur et de ses alliés. Les sorts de Restoration sont également efficaces pour repousser les morts-vivants et les créatures non-vivantes.\n\nPour améliorer cette compétence, le joueur doit utiliser des sorts de Restoration. Plus les sorts sont puissants, plus ils rapportent d'expérience. Le joueur peut également utiliser des sorts ou des potions pour augmenter sa compétence en Restoration.\n\nL'habileté de Restoration est très utile pour les joueurs qui cherchent à survivre aux combats en utilisant des sorts de guérison pour se soigner. Elle est également utile pour les joueurs qui cherchent à repousser les morts-vivants et les créatures non-vivantes.\n\nEn plus de permettre au joueur de lancer des sorts de Restoration, l'habileté de Restoration offre également des bonus passifs en fonction de son niveau. Ces bonus peuvent inclure une augmentation de la vitesse de régénération de la santé, une réduction du coût des sorts de Restoration, ou encore une augmentation de l'efficacité des sorts de guérison.\n\nEn résumé, l'habileté de Restoration est une compétence essentielle pour les joueurs qui cherchent à survivre aux combats en utilisant des sorts de guérison pour se soigner, ainsi que pour repousser les morts-vivants et les créatures non-vivantes.",
                NbrCompetences = 13,
                UtilGen = "Utile pour la protection et le soin.",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 6,
                Difficulté = 6,
                Image1Logo = "https://images.uesp.net/e/ef/SR-perktree-Restoration.jpg",
                Image2SS = "/images/restoration ss.jpg",
                Image3Art = "https://images.uesp.net/e/ec/LG-cardart-Restoration_Tutor.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 5,
                ParentId = 1,
                Parent = Parents[0],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/b/ba/SkillAlteration.png",
                Nom = "Altération",
                Description = "L'habileté d'Altération de Skyrim permet au joueur de manipuler les forces magiques de l'univers pour modifier la réalité. Les sorts d'Altération peuvent être utilisés pour se protéger, augmenter la capacité de transport, détecter des objets cachés, ou encore manipuler la gravité.\n\nPour améliorer cette compétence, le joueur doit utiliser des sorts d'Altération. Plus les sorts sont puissants, plus ils rapportent d'expérience. Le joueur peut également utiliser des sorts ou des potions pour augmenter sa compétence en Altération.\n\nL'habileté d'Altération est très utile pour les joueurs qui cherchent à explorer le monde de Skyrim en toute sécurité. Les sorts de protection peuvent protéger le joueur contre les attaques physiques et magiques, tandis que les sorts de transport peuvent aider le joueur à se déplacer rapidement.\n\nEn plus de permettre au joueur de lancer des sorts d'Altération, l'habileté d'Altération offre également des bonus passifs en fonction de son niveau. Ces bonus peuvent inclure une réduction du coût des sorts d'Altération, une augmentation de la durée des sorts, ou encore une augmentation de la portée des sorts.\n\nEn résumé, l'habileté d'Altération est une compétence essentielle pour les joueurs qui cherchent à explorer le monde de Skyrim en toute sécurité en utilisant des sorts de protection et de transport. Elle permet également de manipuler la réalité à travers des sorts qui peuvent détecter des objets cachés ou manipuler la gravité.",
                NbrCompetences = 14,
                UtilGen = "Utile pour la protection et l'utilité.",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 4,
                Difficulté = 7,
                Image1Logo = "https://images.uesp.net/thumb/d/dd/SR-perktree-Alteration.jpg/300px-SR-perktree-Alteration.jpg",
                Image2SS = "/images/alteration ss.jfif",
                Image3Art = "https://images.uesp.net/8/8c/LG-cardart-Wardcrafter.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 6,
                ParentId = 1,
                Parent = Parents[0],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/c/ce/SkillEnchanting.png/",
                Nom = "Enchantement",
                Description = "L'habileté d'Enchantement de Skyrim permet au joueur d'enchanter des armes, des armures et des objets pour leur donner des propriétés magiques. Les enchantements peuvent ajouter des effets tels que des dégâts de feu, de froid ou de choc, augmenter la vitesse d'attaque ou la résistance à la magie, ou encore améliorer les capacités de furtivité.\n\nPour améliorer cette compétence, le joueur doit utiliser une table d'enchantement et des gemmes d'âme pour créer des enchantements. Plus les enchantements sont puissants, plus ils rapportent d'expérience. Le joueur peut également utiliser des sorts ou des potions pour augmenter sa compétence en Enchantement.\n\nL'habileté d'Enchantement est très utile pour les joueurs qui cherchent à personnaliser leur équipement. Les joueurs peuvent ainsi créer des armes et des armures personnalisées qui correspondent à leur style de jeu. De plus, les enchantements peuvent être utilisés pour renforcer les armes et armures trouvées dans le monde de Skyrim.\n\nEn plus de permettre au joueur d'enchanter des objets, l'habileté d'Enchantement offre également des bonus passifs en fonction de son niveau. Ces bonus peuvent inclure une augmentation de la durée des enchantements, une réduction des coûts d'enchantement, ou encore une augmentation de la puissance des enchantements.\n\nEn résumé, l'habileté d'Enchantement est une compétence essentielle pour les joueurs qui cherchent à personnaliser leur équipement et à ajouter des effets magiques à leurs armes et armures. Elle permet au joueur de créer des objets uniques et puissants qui correspondent à leur style de jeu.",
                NbrCompetences = 13,
                UtilGen = "Utile pour tous. Donne des effets aux armures et armes.",
                TypeAbilite = "Amélioration",
                NiveauDeRecommendation = 10,
                Difficulté = 8,
                Image1Logo = "https://images.uesp.net/e/e0/SR-perktree-Enchanting.jpg",
                Image2SS = "https://images.uesp.net/thumb/b/b9/SR-activity-Arcane_Enchanter.jpg/800px-SR-activity-Arcane_Enchanter.jpg",
                Image3Art = "https://images.uesp.net/5/5a/LG-cardart-Arcane_Enchanter.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 7,
                ParentId = 2,
                Parent = Parents[1],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/2/2b/SkillSmithing.png/",
                Nom = "Forgeage",
                Description = "L'habileté de Forgeage de Skyrim permet au joueur de créer et d'améliorer des armes et des armures en utilisant des matériaux tels que le fer, l'acier, l'or, l'ébène, ou encore le daedra. Cette compétence permet également au joueur de fabriquer des objets utiles tels que des serrures, des clés, ou encore des gantelets de forge.\n\nPour améliorer cette compétence, le joueur doit utiliser une forge et des matériaux pour créer ou améliorer des objets. Plus les objets sont complexes à fabriquer, plus ils rapportent de l'expérience. Le joueur peut également utiliser des sorts ou des potions pour augmenter sa compétence en Forgeage.\n\nL'habileté de Forgeage est très utile pour les joueurs qui cherchent à améliorer leur équipement et à créer des armes et armures personnalisées. Les joueurs peuvent ainsi fabriquer des objets plus puissants que ceux qu'ils trouvent dans le monde de Skyrim.\n\nEn plus de permettre au joueur de créer des objets, l'habileté de Forgeage offre également des bonus passifs en fonction de son niveau. Ces bonus peuvent inclure une augmentation de la qualité des objets fabriqués, une réduction des coûts de fabrication, ou encore une augmentation de la durabilité des objets.\n\nEn résumé, l'habileté de Forgeage est une compétence essentielle pour les joueurs qui cherchent à améliorer leur équipement et à créer des objets personnalisés. Elle permet au joueur de créer des armes et des armures plus puissantes, ainsi que des objets utiles tels que des serrures ou des clés.",
                NbrCompetences = 10,
                UtilGen = "Utile pour tous. Améliore les armures et armes.",
                TypeAbilite = "Amélioration",
                NiveauDeRecommendation = 10,
                Difficulté = 8,
                Image1Logo = "https://images.uesp.net/e/eb/SR-perktree-Smithing.jpg",
                Image2SS = "https://images.uesp.net/thumb/e/e7/SR-activity-Forge.jpg/800px-SR-activity-Forge.jpg",
                Image3Art = "https://images.uesp.net/thumb/0/03/LG-cardart-Sparksmith.png/600px-LG-cardart-Sparksmith.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 8,
                ParentId = 2,
                Parent = Parents[1],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/b/b7/SkillHeavyarmor.png",
                Nom = "Armure Lourde",
                Description = "L'habileté d'Armure Lourde de Skyrim permet au joueur de mieux résister aux attaques ennemies en portant des armures lourdes. Cette compétence améliore la capacité du joueur à encaisser les coups et à réduire les dégâts subis.\n\nPour améliorer cette compétence, le joueur doit porter des armures lourdes en combat et subir des dégâts physiques. Plus le joueur subit de dégâts, plus il gagne d'expérience et monte en niveau dans cette compétence. Le joueur peut également utiliser des sorts ou des potions pour augmenter sa résistance aux dégâts physiques.\n\nL'habileté d'Armure Lourde est très utile pour les joueurs qui préfèrent une approche défensive en combat. Les armures lourdes offrent une meilleure protection contre les dégâts physiques que les armures légères, mais elles sont également plus lourdes et plus bruyantes. Les joueurs doivent donc faire attention à leur endurance et à leur capacité à se déplacer silencieusement.\n\nEn plus de fournir une meilleure protection contre les dégâts physiques, l'habileté d'Armure Lourde offre également des bonus passifs au joueur en fonction de son niveau. Ces bonus peuvent inclure une réduction de poids pour les armures lourdes, une augmentation de la résistance aux sorts, ou encore une augmentation de la santé ou de la force.\n\nEn résumé, l'habileté d'Armure Lourde est une compétence essentielle pour les joueurs qui cherchent à devenir des guerriers défensifs et à résister aux attaques ennemies.",
                NbrCompetences = 12,
                UtilGen = "Utile pour la protection sans furtivité.",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 7,
                Difficulté = 3,
                Image1Logo = "https://images.uesp.net/thumb/0/0d/SR-perktree-Heavy_Armor.jpg/300px-SR-perktree-Heavy_Armor.jpg",
                Image2SS = "https://images.uesp.net/thumb/2/23/SR-item-Dragonplate_Armor_Male.jpg/600px-SR-item-Dragonplate_Armor_Male.jpg",
                Image3Art = "https://images.uesp.net/4/43/LG-cardart-Dragonplate_Armor.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 9,
                ParentId = 2,
                Parent = Parents[1],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/c/c7/SkillBlock.png/",
                Nom = "Bloque",
                Description = "L'habileté de Bloque de Skyrim permet au joueur de se protéger des attaques ennemies en utilisant un bouclier ou une arme à une main. Cette compétence permet d'améliorer la capacité du joueur à bloquer les attaques, à contrer les coups et à pousser l'ennemi en arrière.\n\nPour améliorer cette compétence, le joueur doit bloquer des attaques ennemies avec un bouclier ou une arme à une main en combat. Plus le joueur utilise ces techniques de blocage, plus il gagnera de l'expérience et montera en niveau. Il est également possible d'utiliser des potions ou des sorts pour améliorer la capacité de blocage et de contrer les coups.\n\nL'habileté de Bloque est très utile pour les joueurs qui préfèrent une approche défensive en combat. En utilisant un bouclier, le joueur peut bloquer les attaques ennemies et minimiser les dégâts subis. En utilisant une arme à une main, le joueur peut combiner les techniques de blocage avec des attaques rapides pour vaincre l'ennemi.\n\nCependant, le blocage peut être moins efficace contre les ennemis qui utilisent des attaques à distance, comme les archers ou les mages. Le joueur doit également faire attention à la durabilité de son bouclier, qui peut se briser après avoir subi trop de dégâts.",
                NbrCompetences = 13,
                UtilGen = "Utile pour la protection pour un guerrier.",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 4,
                Difficulté = 4,
                Image1Logo = "https://images.uesp.net/9/90/SR-perktree-Block.jpg",
                Image2SS = "/images/bloque ss.png",
                Image3Art = "https://images.uesp.net/2/23/LG-cardart-Yew_Shield.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 10,
                ParentId = 2,
                Parent = Parents[1],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/f/fa/SkillTwohanded.png/",
                Nom = "Deux Main",
                Description = "Dans Skyrim, l'habileté de Deux Mains (ou \"Two-Handed\" en anglais) permet au joueur de devenir un guerrier puissant et redoutable. Cette compétence permet d'améliorer la puissance et la portée des attaques avec des armes à deux mains comme les épées longues, les haches de guerre, les marteaux et les grandes épées.\n\nPour améliorer cette compétence, le joueur doit utiliser des armes à deux mains en combat. Plus le joueur utilise ces armes, plus il gagnera de l'expérience et montera en niveau. Il est également possible d'utiliser des potions ou des sorts pour améliorer la puissance et la portée des attaques.\n\nDeux Mains est une compétence très utile pour les joueurs qui préfèrent les combats au corps-à-corps. Les armes à deux mains ont une portée plus grande que les armes à une main, ce qui permet au joueur de garder une certaine distance avec l'ennemi tout en infligeant des dégâts. Les armes à deux mains ont également une puissance de frappe supérieure, ce qui permet d'infliger des dégâts massifs à l'ennemi en un seul coup.\n\nCependant, Deux Mains peut être moins efficace contre les ennemis qui sont rapides et agiles, car les armes à deux mains ont une vitesse de frappe plus lente que les armes à une main. Les armes à deux mains peuvent également être plus lourdes et plus difficiles à manier que les armes à une main, ce qui peut rendre cette compétence moins adaptée aux joueurs qui préfèrent la rapidité et la flexibilité en combat.",
                NbrCompetences = 19,
                UtilGen = "Utile pour un guerrier voulant plus de force mais moins de vitesse.",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 7,
                Difficulté = 3,
                Image1Logo = "https://images.uesp.net/3/30/SR-perktree-Two-handed.jpg",
                Image2SS = "https://preorderskyrim.files.wordpress.com/2011/08/skyrim-orc-screenshot-3.jpg",
                Image3Art = "https://images.uesp.net/6/60/LG-cardart-Stormcloak_Skirmisher.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 11,
                ParentId = 2,
                Parent = Parents[1],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/b/b5/SkillOnehanded.png/",
                Nom = "Une Main",
                Description = "Dans Skyrim, l'habileté d'Une Main (ou \"One-Handed\" en anglais) permet au joueur de devenir un combattant redoutable au corps-à-corps. Cette compétence permet d'améliorer la puissance et la vitesse des attaques avec des armes à une main comme les épées, les haches et les masses.\n\nPour améliorer cette compétence, le joueur doit utiliser des armes à une main en combat. Plus le joueur utilise ces armes, plus il gagnera de l'expérience et montera en niveau. Il est également possible d'utiliser des potions ou des sorts pour améliorer la puissance et la vitesse des attaques.\n\nL'Une Main est une compétence très utile pour les joueurs qui préfèrent les combats au corps-à-corps. Les armes à une main sont rapides et permettent au joueur de porter des attaques rapides et précises. Certaines armes à une main ont également des attaques spéciales qui peuvent infliger des dégâts supplémentaires ou désarmer l'ennemi.\n\nCependant, l'Une Main peut être moins efficace contre les ennemis qui sont protégés par une armure lourde ou qui ont une grande résistance physique. Les armes à une main ont également une portée plus courte que les armes à deux mains, ce qui peut rendre cette compétence moins efficace contre les ennemis qui attaquent à distance.",
                NbrCompetences = 21,
                UtilGen = "Utile pour un guerrier voulant moins de force mais plus de vitesse.",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 7,
                Difficulté = 3,
                Image1Logo = "https://images.uesp.net/thumb/9/9f/SR-perktree-One-handed.jpg/300px-SR-perktree-One-handed.jpg",
                Image2SS = "https://www.pcgamesn.com/wp-content/sites/pcgamesn/2022/09/Skyrim-mod-keys-550x309.jpg",
                Image3Art = "https://images.uesp.net/3/3a/LG-cardart-Battlefield_Scrounger.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 12,
                ParentId = 2,
                Parent = Parents[1],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/f/fa/SkillArchery.png/",
                Nom = "Archerie",
                Description = "Dans Skyrim, l'habileté d'Archerie (ou \"Archery\" en anglais) permet au joueur de devenir un tireur d'élite redoutable. Cette compétence permet d'améliorer la précision et la puissance des attaques à distance avec des arcs et des flèches.\n\nPour améliorer cette compétence, le joueur doit utiliser des arcs et des flèches en combat. Plus le joueur utilise cette arme, plus il gagnera de l'expérience et montera en niveau. Il est également possible d'utiliser des potions ou des sorts pour améliorer la précision et la puissance des attaques.\n\nL'Archerie est une compétence très utile pour les joueurs qui préfèrent les combats à distance. Les attaques à l'arc sont silencieuses et permettent au joueur de rester caché et de frapper depuis la sécurité. Les arcs ont une portée plus longue que les armes de mêlée, ce qui permet au joueur de rester en sécurité tout en infligeant des dégâts à distance.\n\nCependant, l'Archerie peut être moins efficace contre les ennemis qui sont capables de se déplacer rapidement et d'esquiver les attaques à distance. Les arcs ont également une cadence de tir plus lente que les armes de mêlée, ce qui peut rendre cette compétence moins efficace contre les ennemis qui attaquent rapidement ou en grand nombre.",
                NbrCompetences = 16,
                UtilGen = "Utile pour les guerriers ou voleurs qui veulent une option de distance.",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 8,
                Difficulté = 4,
                Image1Logo = "https://images.uesp.net/9/9d/SR-perktree-Archery.jpg",
                Image2SS = "/images/archery ss.jpg",
                Image3Art = "https://images.uesp.net/8/80/LG-cardart_Archer%27s_Gambit.jpg"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 13,
                ParentId = 3,
                Parent = Parents[2],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/2/2d/SkillLightarmor.png/",
                Nom = "Armure Légère",
                Description = "Dans Skyrim, l'habileté d'Armure Légère (ou \"Light Armor\" en anglais) permet au joueur de mieux résister aux attaques ennemies tout en conservant une grande mobilité. Plus cette compétence est élevée, moins les attaques ennemies infligeront de dégâts et plus le joueur sera agile.\n\nPour améliorer cette compétence, le joueur doit équiper des pièces d'armure légère et être touché par des attaques ennemies. Les dégâts subis permettront au joueur de gagner de l'expérience et de monter en niveau. Il est également possible d'utiliser des potions ou des sorts pour améliorer la résistance et l'agilité du joueur.\n\nLe joueur peut porter des armures légères en cuir, en peau ou en tissu, qui sont moins lourdes et moins protectrices que les armures lourdes. Cependant, les armures légères permettent au joueur de se déplacer plus rapidement et de bénéficier de bonus d'agilité qui augmentent les chances d'esquiver les attaques ennemies.\n\nCependant, certaines attaques ennemies peuvent pénétrer plus facilement l'armure légère, ce qui rend cette compétence moins efficace contre certains types d'ennemis. De plus, certains types de pièces d'armure légère sont plus efficaces contre certaines formes d'attaques, comme les armures en cuir contre les attaques tranchantes et les armures en tissu contre les attaques magiques.",
                NbrCompetences = 10,
                UtilGen = "Utile pour la protection avec furtivité.",
                TypeAbilite = "Combat",
                NiveauDeRecommendation = 10,
                Difficulté = 8,
                Image1Logo = "https://images.uesp.net/f/f2/SR-perktree-Light_Armor.jpg",
                Image2SS = "https://images.uesp.net/thumb/3/3c/SR-item-Forsworn_Armor_Male.jpg/600px-SR-item-Forsworn_Armor_Male.jpg",
                Image3Art = "https://images.uesp.net/e/e0/LG-cardart-Forsworn_Looter.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 14,
                ParentId = 3,
                Parent = Parents[2],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/8/82/SkillSneak.png/",
                Nom = "Furtivité",
                Description = "Dans Skyrim, l'habileté de Furtivité (ou \"Sneak\" en anglais) permet au joueur de se déplacer de manière furtive et de passer inaperçu auprès des ennemis et des habitants de Skyrim. Plus cette compétence est élevée, plus il sera facile de se cacher et de se déplacer silencieusement.\n\nPour améliorer cette compétence, le joueur doit rester furtif en évitant d'être vu ou entendu par les ennemis et les habitants de Skyrim. Les actions furtives réussies permettront au joueur de gagner de l'expérience et de monter en niveau. Il est également possible d'utiliser des potions ou des sorts pour améliorer la furtivité du joueur.\n\nLe joueur peut se cacher derrière des objets ou se déplacer lentement pour éviter d'être vu ou entendu. Le joueur peut également effectuer des attaques furtives pour infliger des dégâts supplémentaires à ses ennemis.\n\nCependant, si le joueur est détecté, cela peut entraîner des conséquences négatives sur sa réputation et rendre plus difficile l'interaction avec certains personnages du jeu. De plus, certains ennemis sont plus sensibles aux actions furtives que d'autres, et la furtivité peut ne pas être efficace contre certains types d'ennemis.\n",
                NbrCompetences = 13,
                UtilGen = "Utile pour un voleur. Aide à moins se faire détecter.",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 9,
                Difficulté = 6,
                Image1Logo = "https://images.uesp.net/b/b0/SR-perktree-Sneak.jpg",
                Image2SS = "/images/sneak ss.jpeg",
                Image3Art = "https://images.uesp.net/7/78/LG-cardart-Shadowscale_Partisan.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 15,
                ParentId = 3,
                Parent = Parents[2],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/3/3d/SkillLockpicking.png/",
                Nom = "Crochetage",
                Description = "Dans Skyrim, l'habileté du crochetage permet au joueur d'ouvrir les serrures des portes et des coffres verrouillés. " +
                "Plus cette compétence est élevée, plus il sera facile d'ouvrir des serrures complexes." +
                "\n" + "\n" +
                "Pour améliorer cette compétence, le joueur doit réussir des actions de crochetage, ce qui lui permettra de gagner de l'expérience et de monter en niveau. " +
                "Il est également possible d'utiliser des potions ou des sorts pour améliorer ses chances de réussite." +
                "\n" + "\n" +
                "Le joueur doit utiliser des crochets pour faire pivoter les goupilles de la serrure jusqu'à ce que toutes les goupilles soient alignées. " +
                "Si toutes les goupilles sont alignées, la serrure s'ouvrira. Cependant, si le joueur force trop la serrure, il risque de la casser et de ne plus pouvoir l'ouvrir." +
                "\n" + "\n" +
                "Il existe également des serrures spéciales, comme celles des portes des maisons des habitants de Skyrim. " +
                "Si le joueur est pris en flagrant délit de crochetage sur une serrure spéciale, " +
                "cela peut entraîner des conséquences négatives sur sa réputation et rendre plus difficile l'interaction avec certains personnages du jeu." +
                "\n" + "\n" +
                "En résumé, l'habileté du crochetage de Skyrim permet au joueur d'ouvrir des portes et des coffres verrouillés, " +
                "mais cela doit être fait avec prudence pour éviter de casser les serrures ou d'attirer l'attention des habitants de Skyrim.",
                NbrCompetences = 11,
                UtilGen = "Utile pour tous, aide à ouvrir des coffres/portes barrés.",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 3,
                Difficulté = 2,
                Image1Logo = "https://images.uesp.net/5/5e/SR-perktree-Lockpicking.jpg",
                Image2SS = "/images/crochetage.jpg",
                Image3Art = "https://images.uesp.net/7/71/LG-cardart-Thieves_Guild_Recruit.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 16,
                ParentId = 3,
                Parent = Parents[2],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/a/a8/SkillPickpocket.png",
                Nom = "Vol",
                Description = "Dans Skyrim, l'habileté du vol à la tire permet au joueur de voler des objets sur les personnes et les créatures du jeu sans se faire remarquer. " +
                "Plus cette compétence est élevée, plus il sera facile de voler des objets de valeur sans se faire prendre." +
                "\n" + "\n" +
                "Pour améliorer cette compétence, le joueur doit réussir des actions de vol à la tire, ce qui lui permettra de gagner de l'expérience et de monter en niveau. " +
                "Il est également possible d'utiliser des potions ou des sorts pour améliorer ses chances de réussite." +
                "\n" + "\n" +
                "Cependant, voler des objets devant des témoins ou se faire prendre par les gardes peut avoir des conséquences négatives sur la réputation du joueur " +
                "et rendre plus difficile l'interaction avec certains personnages du jeu. " +
                "De plus, certains objets sont considérés comme étant illégaux à voler, et leur possession peut entraîner des poursuites criminelles." +
                "\n" + "\n" +
                "En résumé, l'habileté du vol à la tire de Skyrim permet au joueur de voler des objets de manière furtive et de les ajouter à son inventaire, " +
                "mais cela doit être fait avec prudence pour éviter les conséquences négatives.",
                NbrCompetences = 12,
                UtilGen = "Utile pour un voleur, aide à voler sans se faire prendre.",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 6,
                Difficulté = 10,
                Image1Logo = "https://images.uesp.net/6/68/SR-perktree-Pickpocket.jpg",
                Image2SS = "https://static1.dualshockersimages.com/wordpress/wp-content/uploads/2022/07/PickpocketSkyrim.jpg",
                Image3Art = "https://images.uesp.net/3/31/LG-cardart-Riften_Pickpocket.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 17,
                ParentId = 3,
                Parent = Parents[2],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/1/18/SkillSpeech.png",
                Nom = "Éloquence",
                Description = "L'Éloquence est une compétence qui permet aux joueurs de persuader les personnages non-joueurs (PNJ) de faire ce qu'ils veulent ou de les convaincre de leur donner des informations ou des objets. " +
                "Cette compétence est particulièrement utile pour les joueurs qui souhaitent éviter les combats ou pour ceux qui préfèrent résoudre les problèmes de manière pacifique." +
                "\n" + "\n" +
                "Lorsque les joueurs interagissent avec des PNJ, ils ont la possibilité de choisir différentes options de dialogue, " +
                "qui peuvent être influencées par leur niveau de compétence en Éloquence. Les joueurs peuvent utiliser des compétences comme l'intimidation, " +
                "la persuasion ou la séduction pour influencer les PNJ et obtenir ce qu'ils veulent." +
                "\n" + "\n" +
                "En fonction des situations, les PNJ peuvent être plus ou moins réceptifs aux tentatives de persuasion du joueur. Par exemple, " +
                "un PNJ peut être plus enclin à aider le joueur s'il a une bonne réputation ou s'il a accompli des quêtes pour sa faction." +
                "En plus de persuader les PNJ, la compétence d'Éloquence peut également être utilisée pour acheter et vendre des objets à un prix plus avantageux auprès des marchands. " +
                "Les joueurs peuvent investir dans cette compétence en dépensant des points de compétence pour débloquer des améliorations qui augmentent leur pouvoir de persuasion, " +
                "comme la capacité à vendre des objets à des prix plus élevés ou à persuader les PNJ de faire des choses qu'ils ne feraient pas normalement." +
                "\n" + "\n" +
                "En résumé, la compétence d'Éloquence est un outil essentiel pour les joueurs qui cherchent à résoudre les problèmes de manière pacifique " +
                "ou à obtenir des avantages lors des transactions commerciales. " +
                "Elle leur permet de persuader les PNJ de faire ce qu'ils veulent en utilisant des compétences comme l'intimidation, la persuasion ou la séduction.",
                NbrCompetences = 13,
                UtilGen = "Utile pour tous, donne des meilleurs prix.",
                TypeAbilite = "Utilité",
                NiveauDeRecommendation = 7,
                Difficulté = 4,
                Image1Logo = "https://images.uesp.net/e/e4/SR-item-Gold.jpg",
                Image2SS = "https://images.uesp.net/6/60/SR-perktree-Speech.jpg",
                Image3Art = "https://images.uesp.net/f/fd/LG-cardart-Barter.png"
            });

            Enfants.Add(new Enfant()
            {
                EnfantId = 18,
                ParentId = 3,
                Parent = Parents[2],
                ImageURL = "https://static.wikia.nocookie.net/elderscrolls/images/b/b9/SkillAlchemy.png",
                Nom = "Alchimie",
                Description = "La compétence d'Alchimie dans Skyrim est une compétence très pratique qui permet aux joueurs de créer des potions et des poisons en combinant différents ingrédients. " +
                "Les ingrédients peuvent être trouvés dans tout le monde de Skyrim, des plantes et des champignons poussant dans les forêts aux insectes et aux morceaux d'animaux que l'on trouve sur les routes." +
                "\n" + "\n" +
                "Pour créer une potion, le joueur doit trouver un laboratoire d'alchimie et y placer les ingrédients qu'il souhaite combiner. " +
                "Chaque ingrédient a ses propres effets et valeurs, et en combinant différents ingrédients, le joueur peut créer des potions avec des effets uniques et puissants." +
                "\n" + "\n" +
                "La qualité des potions créées dépend de la compétence du joueur en alchimie, " +
                "qui augmente à mesure que le joueur crée des potions et découvre de nouveaux ingrédients. " +
                "Plus la compétence d'Alchimie du joueur est élevée, plus il sera capable de créer des potions puissantes et de découvrir les effets cachés des ingrédients. " +
                "Les joueurs peuvent également acheter des recettes de potions auprès des marchands ou les trouver en explorant le monde de Skyrim." +
                "\n" + "\n" +
                "Les potions créées peuvent être utilisées pour une variété de tâches, comme améliorer les statistiques du personnage, " +
                "soigner des maladies ou des blessures, ou fournir d'autres avantages temporaires. Les poisons, quant à eux, " +
                "peuvent être utilisés pour empoisonner des armes ou des pièges et infliger des dégâts à des ennemis." +
                "\n" + "\n" +
                "En plus de créer des potions et des poisons, la compétence d'Alchimie permet également aux joueurs de récolter plus d'ingrédients à partir des plantes et des champignons, " +
                "et de vendre des potions à un prix plus élevé aux marchands. " +
                "Cela en fait une compétence très utile pour les joueurs qui cherchent à gagner de l'argent et à améliorer leur personnage.",
                NbrCompetences = 15,
                UtilGen = "Utile pour tous, offre des améliorations.",
                TypeAbilite = "Amélioration",
                NiveauDeRecommendation = 8,
                Difficulté = 4,
                Image1Logo = "https://images.uesp.net/c/c8/SR-perktree-Alchemy.jpg",
                Image2SS = "https://images.uesp.net/7/7a/SR-activity-Alchemy_Lab.jpg",
                Image3Art = "https://images.uesp.net/2/28/LG-cardart-Cauldron_Keeper.png"
            });






            //Liaison objets Enfants aux Objets Parent
            foreach (var p in Parents)
            {
                p.Enfants = new List<Enfant>();
                p.Enfants.AddRange(Enfants.Where(e => e.ParentId == p.ParentId));
            }
            //Liaison objets Parents aux Objets Enfants
            foreach (var e in Enfants)
            {
                e.Parent = Parents.Where(p => p.ParentId == e.ParentId).Single();
            }

            int MageCombat= Enfants.Where(e => e.TypeAbilite == "Combat" && e.ParentId==1).Count();
            Parents[0].CombatSkills = MageCombat; 



        }


    }
}
