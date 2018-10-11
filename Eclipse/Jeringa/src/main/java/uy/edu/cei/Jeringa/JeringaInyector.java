package uy.edu.cei.Jeringa;

import java.io.IOException;
import java.lang.annotation.Annotation;
import java.lang.reflect.Constructor;
import java.lang.reflect.Field;
import java.lang.reflect.InvocationTargetException;
import java.util.Properties;

public class JeringaInyector {
	
	public void inyectar(Object object) throws ClassNotFoundException, NoSuchMethodException, SecurityException, InstantiationException, IllegalAccessException, IllegalArgumentException, InvocationTargetException, IOException {
		Class<?> clazz = object.getClass();
		Field[] fields = clazz.getDeclaredFields();
		for(Field field : fields) {
			System.out.println(field.getName());
			Annotation[] anotaciones = field.getAnnotations();
			for(Annotation anotacion : anotaciones) {
				System.out.println(anotacion.annotationType());
				if(anotacion instanceof Jeringa) {
					Jeringa jeringa = (Jeringa) anotacion;
					String value = jeringa.value();
					
					Properties properties = new Properties();
					properties.load(JeringaInyector.class.getClassLoader().getResourceAsStream("Jeringa.properties"));
					String clazzName = properties.getProperty(value);
					
					Class<?> newClazz = Class.forName(clazzName);
					Constructor<?> constructor = newClazz.getConstructor();
					Object newObject = constructor.newInstance();
					
					field.setAccessible(true);
					field.set(object,newObject);
					field.setAccessible(false);
				}
			}
		}
		System.out.println();
	}
	
}
