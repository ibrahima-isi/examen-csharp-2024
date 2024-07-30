<?php
header('Content-Type: application/json');
include "../backend/db.php";

// Vérifie si l'ID est passé dans les paramètres GET
$id = isset($_GET['id']) ? (int)$_GET['id'] : 0;

if ($id > 0) {
    try {
        // Prépare la requête de suppression
        $stmt = $db->prepare("DELETE FROM utilisateur WHERE id = ?");
        
        // Exécute la requête et récupère le résultat
        $result = $stmt->execute([$id]);

        // Retourne un message JSON de succès ou d'échec
        echo json_encode([
            'success' => $result
        ]);
    } catch (Exception $e) {
        // En cas d'erreur, retourne un message d'erreur
        echo json_encode([
            'success' => false,
            'message' => 'Erreur lors de la suppression : ' . $e->getMessage()
        ]);
    }
} else {
    // Retourne une erreur si l'ID est invalide ou manquant
    echo json_encode([
        'success' => false,
        'message' => 'ID invalide ou manquant.'
    ]);
}
?>
