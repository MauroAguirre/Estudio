package uy.edu.cei.Jeringa;

import static org.junit.Assert.*;

import java.io.IOException;
import java.lang.reflect.InvocationTargetException;

import org.junit.Test;

import uy.edu.cei.Jeringa.models.TestModel;

public class JeringaInyectorTest {

	@Test
	public void testInyectarNotNull() throws ClassNotFoundException, NoSuchMethodException, SecurityException, InstantiationException, IllegalAccessException, IllegalArgumentException, InvocationTargetException, IOException {
		JeringaInyector jeringaInyector = new JeringaInyector();
		TestModel testModel = new TestModel();
		jeringaInyector.inyectar(testModel);
		assertNotNull("esto ta re null boludo",testModel.getTestModelInjectable());
	}

}
