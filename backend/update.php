<?php
    header('Content-Type: application/json');
    include "../backend/db.php";
    foreach($_GET as $p) echo $p;
    $id = $_POST['id'];
    $nom = $_POST['nom'];
    $prenom = $_POST['prenom'];
    $age = (int) $_POST['age'];
    echo $id; 

    $stmt = $db->prepare("UPDATE utilisateur SET nom = ?, prenom = ?, age = ? WHERE id = ?");
    $result = $stmt->execute([$nom,$prenom,$age,$id]);

    echo json_encode([
        'success' => $result
    ]);

?>