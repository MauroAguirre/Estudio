package uy.edu.cei.Jeringa.models;

import uy.edu.cei.Jeringa.Jeringa;

public class TestModel {
	@Jeringa("test")
	private TestModelInjectable testModelinjectable;
	public TestModelInjectable getTestModelInjectable() {
		return testModelinjectable;
	}
}
