En este cap�tulo, profundizaremos un poco en el dise�o, el modelado y la representaci�n de niveles, e implementaremos un recorrido animado que puede experimentar en la realidad virtual.

Para ello seguiremos los siguientes pasos.
1) GalleryRoom in Blender: Realizaremos en Blender el dise�o del cuarto que usaremos para la escena
2) ArtWorkRig: Crearemos una plataforma de arte con un marco de imagen, iluminaci�n y posicionamiento.  
   (Tenemos que ubicarlos segun nuestro modelo jugar con valores de Spotlight)
3) Valor "Position" de los cuadros(ya que no es exactamente la del libro): 
	-(1.65, 0.8, -1.41)
	-(-1.05, 0.8, -4.28)
	-(-2.82, 0.8, -2.6)
	-(-2.82, 0.8, -0.3)
	-(-1,6, 0.8, 1.35)
	-(1.5, 0.8, -1.36)
	-(2.88, 0.8, 0.2)
	-(2.88, 0.8, 2.9)
	-(1.5, 0.8, 4.24)
	-(-1.5, 0.8, 1.4)
	
3) Adding Photos: A�adiremos fotos a los cuadros anteriormente creados.
4) Animated Walk Through: Un recorrido por todo el cuarto, echando un vistazo en cada imagen.

Los archivos del Proyecto est�n en la Carpeta Assets, las dem�s carpetas son librerias importadas y configuraciones. 
Para abrir la escena del trabajo ir a "Assets/Scenes/GalleryRoom.unity"  Donde se encontraran la escena como .unity que se abre en Unity. 

Mejoras a�adidas:
- SkyBox a�adido para que se vea mejor el exterior.
- Limites del mundo para que no parezca como si se fuera a caer.
- Carteles como si fuera un edificio, una galer�a en la vida real(salidas, bienvenidas, zona segura)
- En cada imagen poner como una descripci�n etiqueta, cambiar colores paredes.
- A�adimos un movimiento para que se dirija a la salida, no se quede adentro.(un artworkrig m�s)
- A�adimos sonido o musica de fond(EmptyObject -> Audio Source)

