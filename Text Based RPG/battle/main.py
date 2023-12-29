from classes.game import Person, bcolors
from classes.magic import Spell

# Create Black Magic
fire = Spell("Fire", 10, 100, "black")
thunder = Spell("Thunder", 10, 100, "black")
blizzard = Spell("Blizzard", 10, 100, "black")
meteor = Spell("Meteor", 20, 200, "black")
quake = Spell("Quake", 14, 140, "black")

# Create White Magic
cure = Spell("Cure", 12, 120, "white")
cura = Spell ("Cura", 18, 200, "white")

# Instantiate People
player = Person(260, 65, 60, 36, [fire, thunder, blizzard, meteor, cure, cura])
enemy = Person(1200, 65, 45, 25, [])

running = True
i = 0

print (bcolors.FAIL + bcolors.BOLD + "An Enemy Attacks!" + bcolors.ENDC)

while running:
    print ("==============================")
    player.choose_action()
    choice = input("Choose Action: ")
    index = int(choice) - 1

    if index == 0:
        dmg = player.generate_damage()
        enemy.take_damage(dmg)
        print ("You attacked for", dmg, "points of damage.")
    elif index == 1:
        player.choose_magic()
        magic_choice = int(input("Choose Magic: ")) - 1

        spell = player.magic[magic_choice]
        magic_damage = spell.generate_damage()

        current_mp = player.get_mp()

        if spell.cost > current_mp:
            print (bcolors.FAIL + "\nNot Enough MP\n" + bcolors.ENDC)
            continue
        
        player.reduce_mp(spell.cost)

        if spell.type == "white":
            player.heal(magic_damage)
            print(bcolors.OKBLUE + "\n" + spell.name + " heals for", str(magic_damage), "HP." + bcolors.ENDC)
        elif spell.type == "black":
            player.take_damage(magic_damage)
            print(bcolors.OKBLUE + "\n" + spell.name + " deals", str(magic_damage), "points of damage." + bcolors.ENDC)
        
        enemy.take_damage(magic_damage)
        print (bcolors.OKBLUE + "\n" + spell.name + "deals ", str(magic_damage), "points of damage." + bcolors.ENDC)

    enemy_choice = 1

    enemy_damage = enemy.generate_damage()
    player.take_damage(enemy_damage)
    print ("Enemy attacks for", enemy_damage, "points of damage.")

    print ("=====================================")
    print ("Enemy HP:", bcolors.FAIL + str(enemy.get_hp()) + "/" + str(enemy.get_maxhp()) + bcolors.ENDC)

    print ("Your HP:", bcolors.OKGREEN + str(player.get_hp()) + "/" + str(player.get_maxhp()) + bcolors.ENDC)
    print ("Your MP:", bcolors.OKBLUE + str(player.get_mp()) + "/" + str(player.get_maxmp()) + bcolors.ENDC + "\n")

    if (enemy.get_hp() == 0):
        print(bcolors.OKGREEN + "You win!" + bcolors.ENDC)
        running = False
    elif (player.get_hp() == 0):
        print (bcolors.FAIL + "You are dead!" + bcolors.ENDC)
        running = False

