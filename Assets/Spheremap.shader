Shader "Custom/Spheremap" {
	Properties {
		 _Color ("Main Color", Color) = (1,1,1,1)
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}
	SubShader {
		Tags { "RenderType"="Opaque" }
		Lighting Off
       ZWrite On
       Cull Off
            Pass {
               SetTexture [_MainTex] {
                    constantColor [_Color]
                    Combine texture * constant, texture * constant
                 }
            }
        
	} 
	FallBack "Diffuse"
}

