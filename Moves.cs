using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour {

	/*
	 *       /!\ COMMENCER A LIRE A PARTIR DE "DEPLACEMENT DU GAMEOBJECT" DANS LA FONCTION UPDATE /!\
	 */

	public float speed;

	//Vitesse à utiliser pour les exos.
	public float speed_move;

	bool canFall = true;
	Rigidbody rb;

	void Start()
	{
		//On récupère ici le composant Rigidbody.
		rb = GetComponent<...> ();
	}

	void Update ()
	{
		/* 
		 * Si jamais la variable "canFall" (qui peut prendre pour valeur "true" ou "false") est à true alors on déplace le cube/gameobject selon un vecteur (0,-1,0) donc descendant.
		 * On vérifie à chaque frame la condition "canFall == true" car on se situe dans la fonction Update() de Unity.
		 * La variable "canFall" est modifiée suite à une collision particulière: voir ci-dessous "OnCollisionEnter()".
		 */
		if (canFall == true) 
		{
			transform.Translate (0, -1 * speed * Time.deltaTime, 0);
		} 
		else 
		{
			/* ------DEPLACEMENT DU GAMEOBJECT--------
		 * Afin de déplacer manuellement un gameobject, il faut deux choses: 
		 *  -Récupérer les inputs de l'utilisateur/joueur (les entrées claviers comme appuis de touches etc...).
		 *  -Donner une force avec son sens et sa direction.
		 * 
		 * ------Récupérer les Inputs---------
		 * Unity fournit plusieurs façon de récupérer des inputs grâce à la classe "Inputs".
		 *  -Input.GetKey(KeyCode.touche_du_clavier). Ici "touche_du_clavier" est à remplacer par la lettre que souhaitée (A,Z,...).
		 *  -Input.GetButton("Fire1"). La différence avec le premier est que ici on passe à la fonction GetButton un string (du texte). On peut donc 
		 *  écrire ce que l'on veut à partir du moment que c'est compris entre guillemets (ou que c'est une variable string). Alors comment savoir à quel bouton correspond
		 *  ce texte? Dans l'interface de unity, il faut cliquer sur Edit/Project Settings/Inputs. A droite dans l'inspecteur s'ouvre "InputManager" avec à l'interieur "Axes".
		 *  Il faut alors cliquer sur Axes. Des noms défilent sous axes. Ce sont ces noms qui correspondent au texte mis dans la fonction GetButton. On voit alors que lorsqu'on clique sur un
		 *  des noms plusieurs informations apparaissent. "Positive Button" permet d'indiquer à quelle touche sur le clavier correspond le bouton (nous verrons plus tard à quoi sert le reste).
		 * Les deux fonctions ci-dessus ont donc la même fonctionnalité. Cependant le deuxième permet une meilleur gestion, un meilleur contrôle du bouton.
		 * Enfin il faut savoir qu'il existe la fonction GetAxis qui sera généralement utilisé pour les déplacements mais on y reviendra plus tard.
		 * 
		 * -------Ajouter la force-----------
		 * Encore une fois, il existe plusieurs façons de déplacer un gameobject. On en verra 2 ici: 
		 * -transform.Translate(vecteur);
		 * -rigidbody.velocity
		 * Dans le premier cas on translate l'objet dans le deuxième on lui ajoute une vélocité. La différence? Dans le premier cas on modifie directement la position (x y et/ou z) directement.
		 * Cela pose problème car si on translate le joueur dans un obstacle, la position sera d'abord modifiée et une fois en contact avec l'obstacle (si il y a collision) alors unity le repousse.
		 * Cela créé un effet saccadé. Dans le deuxieme cas (velocity) on ajoute une force géré par unity donc il n'y a pas d'effet de saccade. Par contre cela peut provoquer des pbs (que l'on verra pas ici).
		 * Pour résumer:
		 * dans le premier cas c'est une des manières les plus simples et rapides pour modifier la position d'un gameobject mais selon le contexte ca peut vite provoquer d'enormes problèmes.
		 * dans le deuxième c'est plus smooth/fluide mais pareil selon le contexte c'est moins adapté.
		 * Les deux sont donc utiles.
		 */ 

			/* ------EXERCICES --------
			* Le but ici est de remplacer les "..." par ce qui correspond.
			* Tu vas coder plusieurs fois la même chose n'oublie pas de mettre en commentaire ce qui n'est pas/plus utile.
			*/

			//Déplacement du joueur en appuyant sur la touche D
			if (Input. ...) 
			{
				//Le premier emplacement correspond au sens du vecteur (gauche droite?), le deuxième à la vitesse.
				Vector3 vecteur_de_translation = new Vector3(... * ... * Time.deltaTime, 0, 0);

				//Déplacement par translation.
				//Transmettre le vecteur à la fonction Translate.
				transform...

				//Déplacement grâce à la velocité.
				//A une certaine variable du rigidbody on assigne le vecteur préalablement créé ci-dessus.
				rb... = ...;
			}

			//Déplacement du joueur en appuyant sur la touche Q
			if (Input. ...) 
			{
				//Le premier emplacement correspond au sens du vecteur (gauche droite?), le deuxième à la vitesse.
				Vector3 vecteur_de_translation = new Vector3(... * ... * Time.deltaTime, 0, 0);

				//Déplacement par translation.
				//Transmettre le vecteur à la fonction Translate.
				transform...

				//Déplacement grâce à la velocité.
				//A une certaine variable du rigidbody on assigne le vecteur préalablement créé ci-dessus.
				//La variable rb est obtenue à l'initialisation (dans la fonction Start).
				rb... = ...;
			}
		
			/*
			 * Déplacement du joueur lors de l'appui du bouton appelé "Droite".
			 * Il faut donc créer un bouton dans Input Manager qui s'appelle "Droite".
			 * Edit -> Project Settings -> Inputs -> Axes -> Remplacer le nom de "Fire1" par "Droite".
			 * Utilisation de la fonction GetButton.
			 */

			if (Input.GetButton ("Droite")) 
			{
				//Le premier emplacement correspond au sens du vecteur (gauche droite?), le deuxième à la vitesse.
				Vector3 vecteur_de_translation = new Vector3(... * ... * Time.deltaTime, 0, 0);

				//Déplacement par translation.
				//Transmettre le vecteur à la fonction Translate.
				transform...

				//Déplacement grâce à la velocité.
				//A une certaine variable du rigidbody on assigne le vecteur préalablement créé ci-dessus.
				rb... = ...;
			}

			/*
			 * Déplacement du joueur lors de l'appui du bouton appelé "Gauche".
			 * Il faut donc créer un bouton dans Input Manager qui s'appelle "Gauche".
			 * Edit -> Project Settings -> Inputs -> Axes -> Remplacer le nom de "Fire2" par "Gauche".
			 * Utilisation de la fonction GetButton.
			 */

			if (Input.GetButton ("Gauche")) 
			{
				//Le premier emplacement correspond au sens du vecteur (gauche droite?), le deuxième à la vitesse.
				Vector3 vecteur_de_translation = new Vector3(... * ... * Time.deltaTime, 0, 0);

				//Déplacement par translation.
				//Transmettre le vecteur à la fonction Translate.
				transform...

				//Déplacement grâce à la velocité.
				//A une certaine variable du rigidbody on assigne le vecteur préalablement créé ci-dessus.
				rb... = ...;
			}

			/*
			 * BONUS: On remarque que dans tout les if les lignes se ressemblent ou presque car à qq chose près on effectue la même action.
			 * Il faudrait donc créer une fonction qui prend des paramètres utiles comme un vecteur par exemple?
			 * Remplacer ensuite ces lignes par la fonction.
			 * De plus on remarqueras que l'utilisation de la velocity n'a pas le comportement voulu. Pourquoi ?
			 */

		}
	
	}

	/*
	 * "OnCollisionEnter()" est une fonction de Unity qui détecte les collisions du gameobject auquel est attaché ce script.
	 */
	void OnCollisionEnter(Collision detected_collision)
	{
		/*
		 * La variable "detected_collision" contient toutes les informations liées aux collisions en cours.
		 * On regarde donc si il y a une collision avec un gameobject dont le nom est "Plane". Si c'est le cas alors la variable canFall est à false (ce qui stope la condition dans Update()).
		 */
		if (detected_collision.gameObject.name == "Plane") 
		{
			Debug.Log ("test");
			canFall = false;
		}
	}
}
