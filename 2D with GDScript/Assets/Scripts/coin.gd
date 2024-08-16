extends Area2D

@onready var game_manager = %GameManager
@onready var animation_player = $AnimationPlayer

func _on_body_entered(body):
	game_manager.AddPoint()
	animation_player.play("Pickup")
