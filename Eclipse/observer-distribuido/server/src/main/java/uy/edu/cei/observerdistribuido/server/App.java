package uy.edu.cei.observerdistribuido.server;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;

import uy.edu.cei.observerdistribuido.common.ServerApp;

/**
 * Hello world!
 *
 */
public class App 
{
    public static void main( String[] args ) throws RemoteException
    {
        System.out.println( "Hello World!" );
        ServerApp server = new ServerAppImpl();
        LocateRegistry.createRegistry(1099);
        Registry locateRegistry = LocateRegistry.getRegistry();
        ServerApp stub = (ServerApp) UnicastRemoteObject.exportObject(server,0);
        locateRegistry.rebind("server",stub);
    }
}
