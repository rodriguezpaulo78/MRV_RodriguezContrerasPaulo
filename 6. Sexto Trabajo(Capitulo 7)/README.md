En los capítulos anteriores, el personaje en primera persona se limitaba principalmente al plano de tierra X-Z. Este capítulo se centrará más en el eje y, a medida que exploremos cómo agregar física a la experiencia virtual veremos cómo las propiedades y los materiales basados en la física se pueden agregar a los objetos, así como la forma en que se pueden transferir las fuerzas físicas entre los objetos mediante el uso de scripts C #.

Para ello trabajaremos con nuevas escenas que nos ayudarán a distinguir cada una de estas propiedades:
1) BallsFromHeaven: Cuando una bola cae desde el aire y golpea el suelo, rebota hacia arriba y hacia abajo, y vuelve a subir, disminuida por la gravedad.
2) BallGame: Cuando una bola cae desde arriba de tu cabeza, rebota en ella y apuntas a un objetivo
3) BrickTrampoline: Cuando un ladrillo cae desde el aire hacia un trampolín, rebota y disminuye por la gravedad.
4) HumanTrampoline: Cuando un personaje en primera persona golpea un trampolín, rebota, disminuido por la gravedad. 
5) PhysicsWorld: Una escena más avanzada donde importamos objetos nuevos como WispySky y Planet Earth Pack y hacemos uso de Logos hechos en Blender.

Los archivos del Proyecto están en la Carpeta Assets, las demás carpetas son librerias importadas y configuraciones. 
Para abrir las escenas del trabajo ir a "Assets/Scenes/"  Donde se encontraran las escenas como .unity que se abren en Unity. 

Mejoras Realizadas: 
-Agregar Collider a los logos(en opciones de importacion marcar la casilla generate coliders)
-Elevator otra posicion(hecho)
-SkyBox no se veía en Game Mode(resuelto: Yhttps://answers.unity.com/questions/1223256/skybox-isnt-showing-in-game-view.html///Make sure the camera component has clear flags set to skybox),
-Poner limites para que no se caiga(hecho).


