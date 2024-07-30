<?php
header('Content-Type: application/json');
include "../backend/db.php";

// Vérifie la méthode de la requête
if ($_SERVER['REQUEST_METHOD'] === 'PUT') {
    // Lit les données JSON du corps de la requête
    $data = json_decode(file_get_contents("php://input"), true);

    // Vérifie si les données nécessaires sont présentes
    if (isset($data['Id'], $data['nom'], $data['prenom'], $data['age'])) {
        $id = (int)$data['Id'];
        $nom = $data['nom'];
        $prenom = $data['prenom'];
        $age = (int)$data['age'];

        try {
            // Prépare la requête de mise à jour
            $stmt = $db->prepare("UPDATE utilisateur SET nom = ?, prenom = ?, age = ? WHERE id = ?");
            $result = $stmt->execute([$nom, $prenom, $age, $id]);

            // Retourne un message JSON de succès ou d'échec
            echo json_encode([
                'success' => $result
            ]);
        } catch (PDOException $e) {
            // En cas d'erreur, retourne un message d'erreur
            echo json_encode([
                'success' => false,
                'message' => 'Erreur lors de la mise à jour : ' . $e->getMessage()
            ]);
        }
    } else {
        // Retourne une erreur si les données nécessaires sont manquantes
        echo json_encode([
            'success' => false,
            'message' => 'Données manquantes.'
        ]);
    }
} else {
    // Retourne une erreur si la méthode n'est pas autorisée
    echo json_encode([
        'success' => false,
        'message' => 'Méthode non autorisée.'
    ]);
}
?>
