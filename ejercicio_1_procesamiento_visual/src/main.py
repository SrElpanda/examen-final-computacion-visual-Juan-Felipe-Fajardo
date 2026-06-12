import cv2

# Directorios
INPUT_IMAGE = "../data/arthur.png" 
OUTPUT_DIR = "../resultados"

# Parámetros
GAUSSIAN_KERNEL = (5, 5)
CANNY_THRESHOLD1 = 50
CANNY_THRESHOLD2 = 150

# PIPELINE DE PROCESAMIENTO

# 1. Abrir imagen
original = cv2.imread(INPUT_IMAGE)

# 2. Escala de grises
gray = cv2.cvtColor(original, cv2.COLOR_BGR2GRAY)

# 3. Cambio de color a HSV
hsv = cv2.cvtColor(original, cv2.COLOR_BGR2HSV)

# 4. Suavizado (Gaussiano)
blurred = cv2.GaussianBlur(gray, GAUSSIAN_KERNEL, 0)

# 5. Deteccion de bordes (Canny)
edges = cv2.Canny(blurred, CANNY_THRESHOLD1, CANNY_THRESHOLD2)

# 6. Segmentacion por umbralizacion (Otsu)
_, segmented = cv2.threshold(gray, 0, 255, cv2.THRESH_BINARY + cv2.THRESH_OTSU)

# 7. visualización de resultados
cv2.imshow('Original', original)
cv2.imshow('Grises', gray)
cv2.imshow('HSV', hsv)
cv2.imshow('Suavizado', blurred)
cv2.imshow('Bordes', edges)
cv2.imshow('Segmentacion', segmented)
if cv2.waitKey(0) & 0xFF == ord('q'): # espera hasta que se presione 'q' para cerrar las ventanas
    cv2.destroyAllWindows()

# 8. Guardar resultados
cv2.imwrite(f'{OUTPUT_DIR}/original.png', original)
cv2.imwrite(f'{OUTPUT_DIR}/grises.png', gray)
cv2.imwrite(f'{OUTPUT_DIR}/hsv.png', hsv)
cv2.imwrite(f'{OUTPUT_DIR}/suavizado.png', blurred)
cv2.imwrite(f'{OUTPUT_DIR}/bordes.png', edges)
cv2.imwrite(f'{OUTPUT_DIR}/segmentacion.png', segmented)

