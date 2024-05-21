using UnityEngine;
public class NodeControl : MonoBehaviour
{
    private ListaSimpleEnlazada<Edge> adjacentEdges = new ListaSimpleEnlazada<Edge>();

    public void AddAdjacentEdge(Edge edge)
    {
        adjacentEdges.InsertarNodoAlFinal(edge);
    }
    public Edge SelectRandomAdjacent(NodeControl currentNode)
    {
        Edge selectedEdge;
        do
        {
            int index = Random.Range(0, adjacentEdges.longitud);
            selectedEdge = adjacentEdges.ObtenerNodoPorPosicion(index);
        } while (selectedEdge.NodeA == currentNode && selectedEdge.NodeB == currentNode);
        if (selectedEdge.NodeA == currentNode)
        {
            selectedEdge = new Edge(currentNode, selectedEdge.NodeB, selectedEdge.Weight);
        }
        else if (selectedEdge.NodeB == currentNode)
        {
            selectedEdge = new Edge(selectedEdge.NodeA, currentNode, selectedEdge.Weight);
        }
        return selectedEdge;
    }
}
