# Parcial Final Computación Visual

## Nombre: Juan Felipe Fajardo Garzón
## Fecha de entrega: 13/06/2026


## 1. Descripción General
Este repositorio contiene el desarrollo del parcial final para la asignatura de Computación Visual. El proyecto se compone de dos ejercicios prácticos que abordan los pilares fundamentales de la materia: el procesamiento digital de imágenes en 2D y la construcción de entornos interactivos en 3D. 
* **Ejercicio 1:** Implementación de un pipeline de procesamiento visual secuencial empleando visión por computadora.
* **Ejercicio 2 (Museo):** Diseño y desarrollo de una escena interactiva 3D ambientada en un museo. El proyecto integra el desplazamiento de un avatar mediante un Character Controller, un sistema dinámico de cámara en tercera persona (*Over the Shoulder*), iluminación focal de galería, texturizado PBR y mecánicas de interacción interactiva con las obras expuestas.

## 2. Dependencias
Las herramientas, paquetes y librerías requeridas para la ejecución de ambos proyectos son:
* **Ejercicio 1 (Python):** Python 3.x y OpenCV (`opencv-python`).


* **Ejercicio 2 (Unity):** Unity Editor, Unity Input System package, Cinemachine package y TextMeshPro (TMP).


## 3. Instalación
Clona este repositorio en tu máquina local:

```bash
git clone https://github.com/SrElpanda/examen-final-computacion-visual-Juan-Felipe-Fajardo.git
 ```

Las instrucciones de ejecución se encuentran en los README.md específicos de cada ejercicio

[Ejercicio 1 - Procesamiento Visual](ejercicio_1_procesamiento_visual/README.md)

[Ejercicio 2 - Escena Interactiva 3D (Museo)](ejercicio_2_escena_3d_interactiva/README.md)


## 4. Estructura del Repositorio

```
├───ejercicio_1_procesamiento_visual/   # Proyecto de procesamiento de imágenes 2D
│   ├───data/                           # Imágenes de entrada/origen para el pipeline
│   ├───resultados/                     # Salidas de binarización, bordes y filtros
│   ├───src/                            # Código fuente en Python (main.py)
│   └───README.md                       # Documentación específica del ejercicio 1
├───ejercicio_2_escena_3d_interactiva/  # Proyecto interactivo 3D en Unity
│   ├───media/                          # Recursos multimedia o capturas complementarias
│   ├───Museo_JFFG/                     # Carpeta raíz del proyecto de Unity (Assets, Library, etc.)
│   └───README.md                       # Documentación específica del ejercicio 2
└───README.md                           # Documentación general del parcial (este archivo)
```

## 5. Evidencias

### Ejercicio 1

![alt text](/ejercicio_1_procesamiento_visual/resultados/original.png)



![alt text](/ejercicio_1_procesamiento_visual/resultados/grises.png)



![alt text](/ejercicio_1_procesamiento_visual/resultados/hsv.png)



![alt text](/ejercicio_1_procesamiento_visual/resultados/suavizado.png)



![alt text](/ejercicio_1_procesamiento_visual/resultados/bordes.png)


![alt text](/ejercicio_1_procesamiento_visual/resultados/segmentacion.png)

### Ejercicio 2

![text](/ejercicio_2_escena_3d_interactiva/media/hermes.png)


![alt text](/ejercicio_2_escena_3d_interactiva/media/david.png)


![alt text](/ejercicio_2_escena_3d_interactiva/media/discobolo.png)


![alt text](/ejercicio_2_escena_3d_interactiva/media/venus.png)

Para más evidencias revisar los README.md de cada ejercicio

## 6. Análisis técnico

Revisar los README.md correspondientes de cada ejercicio

[Ejercicio 1 - Procesamiento Visual](ejercicio_1_procesamiento_visual/README.md)

[Ejercicio 2 - Escena Interactiva 3D (Museo)](ejercicio_2_escena_3d_interactiva/README.md)

## 7. Uso de IA

Se empleó asistencia de Inteligencia Artificial Generativa bajo la metodología de co-piloto técnico. El uso se centró en la refactorización de scripts de C# bajo el principio de responsabilidad única, la resolución de excepciones de colisión (MissingComponentException) y la corrección de bucles de animación en el Inspector 