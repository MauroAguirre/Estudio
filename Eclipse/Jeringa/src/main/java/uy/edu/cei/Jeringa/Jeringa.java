package uy.edu.cei.Jeringa;

import static java.lang.annotation.ElementType.FIELD;
import static java.lang.annotation.RetentionPolicy.RUNTIME;

import java.lang.annotation.Retention;
import java.lang.annotation.Target;

/**
 * 
 * @author Mauro
 * class A{
 *  @@Jeringa( value = "pepe")
 *  B b;
 *  }
 */
@Retention(RUNTIME)
@Target(FIELD)
public @interface Jeringa {
	String value();
}
