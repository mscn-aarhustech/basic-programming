Get ArgoCD default password:

[System.Text.Encoding]::UTF8.GetString(
  [System.Convert]::FromBase64String(
    (kubectl get secret argocd-initial-admin-secret -n argocd -o jsonpath="{.data.password}")
  )
)

Username: admin
Password: (output above)
