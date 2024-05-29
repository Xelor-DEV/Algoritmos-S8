using UnityEngine;

public class NodeControl : MonoBehaviour
{
    private ListaSimpleEnlazada<Edge> outgoingEdges = new ListaSimpleEnlazada<Edge>(); // Aristas salientes

    public void AddOutgoingEdge(Edge edge)
    {
        outgoingEdges.InsertarNodoAlFinal(edge);
    }

    public Edge SelectRandomOutgoing(NodeControl currentNode)
    {
        ListaSimpleEnlazada<Edge> validEdges = new ListaSimpleEnlazada<Edge>();
        for (int i = 0; i < outgoingEdges.longitud; i++)
        {
            Edge edge = outgoingEdges.ObtenerNodoPorPosicion(i);
            if (edge.NodeA == currentNode)
            {
                validEdges.InsertarNodoAlFinal(edge);
            }
        }

        if (validEdges.longitud == 0)
        {
            Debug.Log("No hay aristas salientes válidas desde el nodo actual.");
        }

        int index = Random.Range(0, validEdges.longitud);
        return validEdges.ObtenerNodoPorPosicion(index);
    }
}

