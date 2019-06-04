En los cap�tulos anteriores, el personaje en primera persona se limitaba principalmente al plano de tierra X-Z. Este cap�tulo se centrar� m�s en el eje y, a medida que exploremos c�mo agregar f�sica a la experiencia virtual veremos c�mo las propiedades y los materiales basados en la f�sica se pueden agregar a los objetos, as� como la forma en que se pueden transferir las fuerzas f�sicas entre los objetos mediante el uso de scripts C #.

Para ello trabajaremos con nuevas escenas que nos ayudar�n a distinguir cada una de estas propiedades:
1) BallsFromHeaven: Cuando una bola cae desde el aire y golpea el suelo, rebota hacia arriba y hacia abajo, y vuelve a subir, disminuida por la gravedad.
2) BallGame: Cuando una bola cae desde arriba de tu cabeza, rebota en ella y apuntas a un objetivo
3) BrickTrampoline: Cuando un ladrillo cae desde el aire hacia un trampol�n, rebota y disminuye por la gravedad.
4) HumanTrampoline: Cuando un personaje en primera persona golpea un trampol�n, rebota, disminuido por la gravedad. 
5) PhysicsWorld: Una escena m�s avanzada donde importamos objetos nuevos como WispySky y Planet Earth Pack y hacemos uso de Logos hechos en Blender.

Los archivos del Proyecto est�n en la Carpeta Assets, las dem�s carpetas son librerias importadas y configuraciones. 
Para abrir las escenas del trabajo ir a "Assets/Scenes/"  Donde se encontraran las escenas como .unity que se abren en Unity. 

Mejoras Realizadas: 
-Agregar Collider a los logos(en opciones de importacion marcar la casilla generate coliders)
-Elevator otra posicion(hecho)
-SkyBox no se ve�a en Game Mode(resuelto: Yhttps://answers.unity.com/questions/1223256/skybox-isnt-showing-in-game-view.html///Make sure the camera component has clear flags set to skybox),
-Poner limites para que no se caiga(hecho).


